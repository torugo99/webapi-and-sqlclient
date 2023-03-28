# 🌐 | WebApi and SqlClient.

## 💻 | Projeto: Construindo uma API utilizando o pacote System.Data.SqlClient.

Seja bem vindo, esse projeto foi feito no intuito de criar uma API com SQL server utilizando o pacote SqlClient.

A utilização do System.Data.SqlClient é para poder ter uma conexão com database sem a necessidade de um ORM para intermédio de acessar, buscar e inserir dados, como deve ver em meu projeto eu faço Querys para a interação com banco, dando uma liberdade de construção das tabelas até mesmo a injeção de dados nas mesmas.

Fiz a utilização de Dtos e da Lib do AutoMapper para melhorar a utilização da API.

- Utilizando a linguagem C#.
- Utilizando banco de dados SQLServer.

## ⚙ | API.

### ✔ | Tecnologias:
- .NET 6
- AutoMapper 12.0.1
- System.Data.SqlClient 4.8.5


### ⌨ | Comandos

| **Comandos**                                   |                                               **Descrição**|
|------------------------------------------------|------------------------------------------------------------|
|                                  `dotnet build`|                Constroi o projeto e todas suas dependências|
|                                    `dotnet run`|                                            Inicia o projeto|

## 📝 | Utilizando a API:

Para acessar a API, basta clicar no Link do swagger a baixo após rodar o dotnet run: 
- [Link LocalHost com Swagger](https://localhost:7060/swagger/index.html)

API em si é bem simples de ir utilizando, meu passo a passo de utilização vai ser criando um client e vinculando ele em um user.

Iremos inserir:

- O Nome do Cliente (name_client).
- O Id do usuário (user_id) para vincular no cadastro do cliente.
- A data de criação pode ser utilizado o que o swagger gera.

O Id do Cliente é gerado automaticamente quando é criado, o cadastro de usuário segue do mesmo jeito.

![preview1 img](/docs/img/swagger-01.png)

Podemos ver o retorno utilizando o endpoint de buscar por Id, no caso seria o detalhar do cliente.

![preview2 img](/docs/img/swagger-02.png)

Fiz questão de criar um endpoint no ClientController para buscar somente os clientes vinculados a um usuário.

![preview3 img](/docs/img/swagger-03.png)

### 🌐 | Endpoints:
Os endpoint esperados estão funcinando perfeitamente.

<details><summary>Endpoints de User</summary>
<p>

| Verbo  | Endpoint                  | Parâmetro | Body             |
|--------|---------------------------|-----------|------------------|
| POST   | /User/post/               | N/A       | Schema User      |
| GET    | /User/get-all/            | N/A       | N/A              |
| GET    | /User/get-by-id/{user_id} | user_id   | N/A              |
| PUT    | /User/{user_id}           | user_id   | Schema User      |
| DELETE | /User/{user_id}           | user_id   | N/A              |

</p>
</details>

<details><summary>Endpoints de Client</summary>
<p>

| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| POST   | /Client/post/           | N/A       | Schema Client |
| GET    | /Client/get-all/        | N/A       | N/A           |
| GET    | /Client/get-clients-by-user/{user_id}     | id        | N/A           |
| GET    | /Client/get-by-id/{client_id}     | id        | N/A           |
| PUT    | /Client/update/{client_id}     | id        | Schema Client |
| DELETE | /Client/delete/{client_id}     | id        | N/A           |

</p>
</details>

O schema (model) dos endpoitns, são utilizado para passar os campos exigidos, como no verbo POST e PUT.

Todas solicitações como GET, POST, PUT e DELETE que correspondem como CREATE, READ, UPDATE e DELETE (CRUD) estão funcionando.

Visualização do Swagger:

![preview4 img](/docs/img/swagger-04.png)

<b>Segue a lista de commits para verificar o que foi implementado e alterado! Utilizo o Conventional Commits Pattern para ajudar e detalhar o contexto de cada commit efetuado.</b>

## 👩‍💻 Meus Links:

- Github: [Victor Hugo.](https://github.com/torugo99)
- LinkedIn: [Victor Hugo.](https://www.linkedin.com/in/victor-hugo99/)
- Meu Site: [Victor99dev.](http://victor99dev.site/)

### 😀 | Créditos e Agradecimentos:
- Todas as informações do .Net, sendo comandos ou qualquer outra informação foi retirada da documentação oficial.
- Documentações: 
    - [.Net](https://learn.microsoft.com/pt-br/dotnet/)
    - [Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-7.0)
    - [Automapper](https://automapper.org/)
    - [SQL Server](https://learn.microsoft.com/en-us/azure/azure-sql/database/free-sql-db-free-account-how-to-deploy?view=azuresql)
    - [System.data.sqlclient doc 1](https://learn.microsoft.com/pt-br/dotnet/api/system.data.sqlclient?view=windowsdesktop-7.0)
    - [System.data.sqlclient doc 2](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient?view=netframework-4.7.2)
    - [System.data.sqlclient doc 3](https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.connectionstring?view=dotnet-plat-ext-7.0)
- Dbeaver é por onde acesso meus bancos de dados: [Link](https://dbeaver.io/)
