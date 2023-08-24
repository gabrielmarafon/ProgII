Gabriel Marafon - Atividade de fixação
1 - Crie um projeto com ASPNET MVC (template) com nome PjGabrielMarafon
2 - Configure no projeto os nuget packages do EF core
3 - Especifique uma classe Model para Psicologo e defina com DbContext herdando do Identity
4 - Configure no APPSETTINGS Json uma string de conexão com o SQL SERVER
5 - Defina os parametros de config dos servidores da app no program cs
6 - Crie a migration e atualize o banco de dados

1 - Criação do projeto utilizando cmd 
	- dotnet new mvc --no-https --output PjGabrielMarafon

2 - Para termos compatibilidade com o SDK utilizamos a versão 6.20 das dependências que são encontradas no gerenciados de pacotes do Visual Studio.

3 - Depois da criação da classe, definir parâmetros dos psicos e extensões de referência. 

4 - Depois de configurar o appsettings json para conexão com o sql server definimos algum alertas e dados de acesso para administradores.

5 - No program cs definimos os parâmetros para o servidor do app bem como procedimentos e definições do appUser.

6 - Execução dos dois comandos para criação e execução do migration
	- dotnet ef migrations add Initial
	- dotnet ef database update