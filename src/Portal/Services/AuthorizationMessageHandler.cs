using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Services
{
	public class AuthorizationMessageHandler : DelegatingHandler
	{
		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelToken)
		{
			HttpRequestHeaders headers = request.Headers;

			AuthenticationHeaderValue authHeader = headers.Authorization;

			if (authHeader != null)
				headers.Authorization = new AuthenticationHeaderValue(authHeader.Scheme, "Bearer");

			return await base.SendAsync(request, cancelToken);
		}
	}
}
