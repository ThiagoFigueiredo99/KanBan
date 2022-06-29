PT-BR

<h1>Criação de um projeto Kanban</h1>
  
Este é um projeto em desenvolvimento para estudo e treinamento em uma formação inicial de programação em C# .NET, onde a entrega do mesmo é dividida em 3, que seguem abaixo:

### v0.1 - Primeira etapa: Implementação de todas as entidades do projeto (Usuários, Cartões e Sprints)
 Nesta primeira etapa, foi feito a criação das entidades que serão utilizadas no projeto e suas ligações. Criou-se os arquivos:

### User.cs

+ Id - Identificador de cada usuário;
+ Name - Nome de cada usuário.
### Sprint.cs
+ Id - Identificador de cada Sprint;
+ Name - Nome de cada string.
### Card.cs
+ Id - Identificador de cada cartão;
+ Title - Título de cada cartão;
+ Description - Descrição do cartão;
+ UserId - Chave estrangeira da classe User;
+ Estimate - Estimativa de tempo de conclusão do cartão;
+ SprintId - Chave estrangeira da classe Sprint;
+ Status - Estado que o cartão se encontra: Não iniciado, em andamento ou finalizado.
### v0.2 - Segunda etapa: Implementação do banco de dados, migrations e criação das tabelas.
Nesta etapa foi feito a criação do banco de dados utilizando o PostgreSQL e ElephantSQL. Através do auxílio do Entity Framework foi possível a configuração das tabelas que foram criadas a partir das propriedades das entidades User, Sprint e Card. Utilizando migration montou-se e atualizou-se as tabelas para as configurações necessárias.

Assim nesta etapa, através de um algoritmo provisório, é possível observar a criação e exclusão de cada entidade no banco de dados, já conectado a nuvem através do ElephantSql.

### v0.3 Terceira entrega: Implementação completa do projeto, onde engloba todos onde endpoints da API(CRUD e demais endpoints).
> Em andamento ⚠️
## Tecnologias usadas 

<table>
  <tr>
    <td>.NET</td>
    <td>PostgreSQL</td>
    
  </tr>
  
  <tr>
    <td>6.*</td>
    <td>14.4</td>
  </tr>
     
  </table>
