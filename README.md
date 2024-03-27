# TimeDogsApi

Utilize o arquivo BDSQL para criar as tabelas do banco de dados no pgAdmin, nome do Banco de Dados timedogs.
Configuracoes realizadas no arquivo infraestrutura/ConnectionContext.cs

https://localhost:7223/api/v1/raca
Post: utilizado para cadastrar as racas no BD
Formato: 
{
  "name": "string",
  "apresentacao": "string",
  "sobre": "string"
}

Get: Utilizado para obter todas as racas em uma lista

https://localhost:7223/api/v1/raca/{id}
Get: Passar o parametro id para trazer uma raca expecifica

https://localhost:7223/api/v1/cachorro/{id}
Get: Passar o parametro id para trazer um cachorro especifico
