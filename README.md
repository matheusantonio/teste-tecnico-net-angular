# Teste técnico .NET e Angular

Implementação de um CRUD (Create, Read, Update, Delete) de usuários utilizando .NET, Angular e SQL Server

## Para executar

É necessário executar o script de criação do banco (script-usuarios.sql) e alterar a string de conexão no arquivo appSettings.json.

O backend e o frontend devem ser executados separadamente. Para executar o frontend, é necessário executar o comando npm install para instalar as dependências e, em seguida, ng serve para executar a aplicação.

Para executar o backend, a solução pode ser aberta no Visual Studio. Caso métodos alternativos sejam utilizados, atentar-se para a porta da API no arquivo environment.ts. O frontend foi desenvolvido com a API utilizando a porta 44385.

## Considerações

Apesar do escopo do teste ser bem simples, alguns conceitos mais complexos foram utilizados para implementá-lo, como CQRS. Entendo que em contextos simples, nem sempre é necessário aplicar esses conceitos, porém para fins de avaliação, utilizei mesmo assim. Ainda assim, possuo algumas considerações quanto a elementos que deixei de fora, principalmente pelo tempo dado para a execução do teste, mas que acho que seriam interessantes de se mencionar.

* A aplicação não apresenta nenhum tipo de autenticação, porém eu teria usado JWT.
* Para aplicações mais robustas, usar métodos Async e Await pode gerar um ganho de performance. Para simplificar, não utilizei.
* Para contextos que utilizem eventos, acho que seria interessante sobrescrever a implementação do DbContext para interceptar chamadas subsequentes a eventos em uma mesma requisição.
* Em um contexto mais complexo, eu utilizaria a biblioteca Mediatr para implementar o padrão CQRS.
* Em um contexto em que o disparo de exceções fosse mais custoso, eu faria o uso do Notification Pattern para disparar erros no backend

## Imagens



