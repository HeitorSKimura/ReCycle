# ReCycle

## 01 - Para criação de um novo banco de dados

Ferramentas -> Gerenciador de Pacotes do NuGet -> Console do Gerenciador de Pacotes

## 02 - Dentro do console de pacotes canto superio Direito selecionar ( 04 - Infra.SqlServer ) e iniciar os seguintes comandos:

PM> Add-Migration QualquerNome
PM> Update-Database

## 03 - Para Verificar o conteudo do Banco de Dados

Exibir -> Pesquisador de Projetos do SQL Server

## 04 - Selecione a pasta: 

SQL Server -> localdb -> Banco de Dados do Sistema -> ReCycle -> Tabelas 

# Atenção:
## Não esqueça de apagar a Migration em Infra.SqlServer e apagar o Banco de Dados Local em Exibir -> Pesquisador de Projetos do SQL Server após apagar os seguintes campos retomar os comandos do campo 02
