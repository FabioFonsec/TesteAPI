# Sistema de Gerenciamento de Estudantes

Este repositório contém um projeto completo de gerenciamento de estudantes, implementando uma API RESTful usando ASP.NET Core e uma interface de usuário com Blazor WebAssembly. A API permite operações CRUD (Criar, Ler, Atualizar, Deletar) em uma tabela de estudantes que inclui campos como ID, nome, idade e turma.

## Tecnologias Utilizadas

- **ASP.NET Core** para a construção da API RESTful.
- **Entity Framework Core** para o mapeamento objeto-relacional (ORM).
- **SQL Server** como banco de dados.
- **Blazor WebAssembly** para a interface de usuário no lado do cliente.
- **C#** como linguagem de programação.

## Estrutura do Projeto

O projeto está dividido em duas partes principais:

- **API Backend**: Localizada na pasta `API`, essa parte do projeto contém todos os endpoints necessários para realizar operações CRUD na base de dados.
- **Cliente Blazor WebAssembly**: Localizado na pasta `Client`, este projeto contém os componentes Blazor que interagem com a API para exibir e modificar dados.

## Configuração

### Pré-requisitos

Para executar este projeto, você precisará instalar:

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) com suporte para desenvolvimento em ASP.NET e web

### Configuração do Banco de Dados

1. Certifique-se de que o SQL Server está instalado e em execução.
2. Execute o script SQL localizado em `Scripts/sql_script.sql` para criar e popular a base de dados inicial.

### Executando o Projeto

1. Abra a solução do projeto no Visual Studio.
2. Configure a string de conexão no arquivo `appsettings.json` da API para apontar para seu SQL Server.
3. Execute o projeto API para servir os endpoints da API.
4. Execute o projeto Cliente para iniciar a aplicação Blazor WebAssembly.

## Como Contribuir

Contribuições são sempre bem-vindas! Aqui estão algumas maneiras de contribuir para este projeto:

- Relate bugs e sugira melhorias abrindo issues.
- Envie pull requests com correções e melhorias de código.

Antes de enviar uma pull request, certifique-se de testar as alterações localmente.

## Licença

Este projeto é distribuído sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

## Contato

Para mais informações, por favor, entre em contato com [Fábio Fonseca](fabiosfon@gmail.com).

---

Esperamos que você encontre este projeto útil para aprender e implementar suas próprias soluções usando ASP.NET Core e Blazor WebAssembly!
