# ReCycle

## Aplicativos Necessários:
Visual Studio - https://visualstudio.microsoft.com/pt-br/downloads/ (Comunidade)
<br/>
SDK - https://dotnet.microsoft.com/download

### Items Necessários Para o Visual Studio:
- ASP.NET e Desenvolvimento WEB
- Desenvolvimento para Desktop com .NET
- Processamento e Armazenamentos de Dados

## Para Clonar e Executar o Repositorio:
1. Clone o repositório: `git clone https://github.com/HeitorSKimura/ReCycle.git`
2. Abra o projeto no Visual Studio.
3. Restaure as dependências: `dotnet restore`
4. Execute o aplicativo: `dotnet run` F5

## 01 - Para criação de um novo banco de dados
Ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes

## 02 - Dentro do console de pacotes canto superio Direito selecionar ( 04 - Infra.SqlServer ) e iniciar os seguintes comandos:
`PM> Add-Migration QualquerNome`
<br/>
`PM> Update-Database`

## 03 - Para Verificar o conteudo do Banco de Dados
Exibir -> Pesquisador de Projetos do SQL Server

## 04 - Selecione a pasta: 
SQL Server -> localdb -> Banco de Dados do Sistema -> ReCycle -> Tabelas 

# Atenção:
## Não esqueça de apagar a Migration em (Infra.SqlServer) e apagar o Banco de Dados Local em (Exibir -> Pesquisador de Projetos do SQL Server) após apagar os seguintes campos retomar os comandos do campo 02


## Confira Tambem o Front-End = https://github.com/2joaopedro/Front_End_ReCycle.git
