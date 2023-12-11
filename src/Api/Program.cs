using Api.Models;
using Application;
using Application.EntityFrameworkCore;
using AutoMapper;
using Core.Identity;
using DNTCommon.Web.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.WebEncoders;
using Microsoft.OpenApi.Models;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
				 .SetBasePath(Directory.GetCurrentDirectory())
				 .AddJsonFile("appsettings.json")
				 .Build();


// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(config.GetConnectionString("DefaultConnection")));

builder.Services.Configure<KestrelServerOptions>(options =>
			{
				options.AllowSynchronousIO = true;
			});

builder.Services.Configure<IISServerOptions>(options =>
{
	options.AllowSynchronousIO = true;
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddIdentityCore<AppUser>()
				.AddEntityFrameworkStores<AppDbContext>()
				.AddApiEndpoints();

builder.Services.AddHttpContextAccessor();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
builder.Services.AddAuthorizationBuilder();

builder.Services.AddHealthChecks();
 
builder.Services.Configure<AntiDosConfig>(options => config.GetSection("AntiDosConfig").Bind(options));
builder.Services.Configure<AntiXssConfig>(options => config.GetSection("AntiXssConfig").Bind(options));

builder.Services.AddDNTCommonWeb();
 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setupAction =>
{
	setupAction.SwaggerDoc(
	   name: "MttechneAPISpecification",
	   info: new Microsoft.OpenApi.Models.OpenApiInfo()
	   {
		   Title = "Mttechne API",
		   Version = "1",
		   Description = "Api de integração",
		   Contact = new OpenApiContact()
		   {
			   Email = "renannn@outlook.com",
			   Name = "Desenvolvimento",
			   Url = new Uri("http://www.Mttechne.com.br")
		   }
	   });

	var xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
	xmlFiles.ForEach(xmlFile => setupAction.IncludeXmlComments(xmlFile));

	setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
	{
		Type = SecuritySchemeType.ApiKey,
		Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",
		In = ParameterLocation.Header,
		Name = "Authorization",
		Scheme = "bearer",
		BearerFormat = "JWT"
	});

	setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference
							{
								Type = ReferenceType.SecurityScheme,
								Id = "Bearer"
							}
						},
						new List<string>()
					}
				});
});

var mapperConfig = new MapperConfiguration(mc =>
{
	mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.Configure<WebEncoderOptions>(options =>
{
	options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(setupAction =>
	{
		setupAction.SwaggerEndpoint(
			url: "/swagger/MttechneAPISpecification/swagger.json",
			name: "API");

		setupAction.DefaultModelExpandDepth(2);
		setupAction.DefaultModelRendering(Swashbuckle.AspNetCore.SwaggerUI.ModelRendering.Model);
		setupAction.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
		setupAction.EnableDeepLinking();
		setupAction.DisplayOperationId();
	});
}

app.MapHealthChecks("/health");

app.MapGroup("/account").MapIdentityApi<AppUser>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
