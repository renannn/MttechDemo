# Projeto Demo de Controle de Fluxo de caixa

## Arquitetura do projeto

![Arquitetura](/Imagens/Architecture.png)

Projeto multi layers composto de 2 projetos principais o Portal e a API.
Porem estes projetos contem uma serie de subprojetos.

![Project](/Imagens/Project.PNG)


- No projeto da APi possui 2 projetos de framework.
*  **Core** no qual  no qual incluem as representações das tabelas do banco de dados como entidades.
* **Application** um pacote de acesso ao acesso a base de dados utilizando Entity Framework e o padrão Unity of Work.

No projeto de Api foi implementado um Firewall de borda e Anti DDOS:


![Config-AntiDDOS](/Imagens/AntiDDOS-config.PNG)
<br/>
![Startup-AntiDDOS](/Imagens/AntiDDOS-Startup.PNG)


Para o projeto Portal uma aplicação Windows Form implementada usando o modelo de MVC utilizando controladoras baseadas no Framework **REFIT** no qual cada controladora representa por Interfaces as solicitações a Api para persistencia de dados.

Ambos projetos possuem Models compartilhadas em um projeto Shared 

![Shared-Project](/Imagens/Shared-Project.PNG)


Para execução da solicitação Necessita-se a instancia de uma base de dados SQL SERVER

Executando Script abaixo:
[Script.SQL](https://github.com/renannn/MttechDemoSQL/blob/main/init.sql)

Para facilitar o processo preparei um docker-compose contendo a instalação do MICROSOFT SQL SERVER 2022 totalmente configurado para aplicação:

[Docker-SQL-SERVER](https://github.com/renannn/MttechDemoSQL)

Para execução do projeto necessita-se abrir a solução Mttechne.sln com o Visual Studio e apenas executar o projeto foi configurado para iniciar a Api e o Portal simultaneamente.

Para mudanças de Connection string encontra-se no Arquivo `appsettings.json` da aplicação Api

