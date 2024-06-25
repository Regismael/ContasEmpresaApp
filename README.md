# ContasEmpresaApp

Projeto de API ASP.NET Core 8.0 para pagamento de contas de uma empresa específica.

## Visão Geral

Este projeto é uma API desenvolvida em ASP.NET Core 8.0, voltada para o pagamento de contas de uma empresa fictícia. Utiliza o Entity Framework Core no modo "Code First" para o mapeamento de dados, permitindo a manipulação de contas e pagamentos através de operações CRUD.

## Funcionalidades

- **Pagamento de Contas:** Implementado através do método HTTP DELETE para realizar o pagamento de uma conta específica.
- **Mapeamento de Dados:** Utiliza Entity Framework Core no modo "Code First" para definir e persistir os modelos de dados relacionados às contas da empresa.
- **CORS (Cross-Origin Resource Sharing):** Configurado para permitir o acesso da API a partir de origens diferentes, facilitando a integração com projetos front-end.

## Requisitos

- .NET Core SDK 8.0 ou superior
- Visual Studio 2022 (ou outra IDE compatível com .NET Core)
- Banco de dados SQL Server (ou outro suportado pelo Entity Framework Core)

## Configuração

1. Clone este repositório.
2. Abra o projeto no Visual Studio 2022.
3. Configure a conexão com o banco de dados no arquivo `appsettings.json`.
4. Execute o comando `dotnet ef database update` para aplicar as migrações e criar o banco de dados.
5. Execute o projeto para iniciar a API.

## Exemplo de Uso

### Pagamento de Conta

Para pagar uma conta, envie uma requisição DELETE para o endpoint `/api/pagar/contas/{id}`, onde `{id}` é o identificador da conta a ser paga.

Exemplo usando cURL:

```bash
curl -X DELETE https://localhost:5001/api/pagar/contas/1
