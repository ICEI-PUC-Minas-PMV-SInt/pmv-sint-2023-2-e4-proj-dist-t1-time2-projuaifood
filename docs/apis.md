<!--# Especificação de APIs

> A especificação de APIs descreve os principais endpoints da API RESTful do produto
> de software, os métodos HTTP associados a cada endpoint, suas descrições, os formatos
> de respostas, os parâmetros de URL esperados e o mecanismo de autenticação e autorização 
> utilizado.

| Endpoint                             | Método | Descrição                                      | Parâmetros                        | Formato da Resposta | Autenticação e Autorização |
|--------------------------------------|--------|------------------------------------------------|-----------------------------------|---------------------|----------------------------|
| /api/users/{user_id}/tasks/          | GET    | Obter todas as tarefas cadastradas             | user_id (string)                  | JSON                | JWT Token                  |
| /api/users/{user_id}/tasks/{task_id} | POST   | Criar uma nova tarefa                          | user_id (string) task_id (string) | JSON                | JWT Token                  |
| /api/users/{user_id}/tasks/{task_id} | GET    | Obter detalhes de uma tarefa específica        | user_id (string) task_id (string) | JSON                | JWT Token                  |
| /api/users/{user_id}/tasks/{task_id} | PUT    | Atualizar os detalhes de uma tarefa específica | user_id (string) task_id (string) | JSON                | JWT Token                  |
| /api/users/{user_id}/tasks/{task_id} | DELETE | Excluir uma tarefa específica                  | user_id (string) task_id (string) | JSON                | JWT Token                  |

[Retorna](../README.md) -->

# Especificação de APIs

| Endpoint                                | Método | Descrição                                       | Parâmetros                                        | Formato da Resposta | Autenticação e Autorização |
|-----------------------------------------|--------|-------------------------------------------------|---------------------------------------------------|---------------------|----------------------------|
| /api/farmers/products                   | GET    | Obter todos os produtos cadastrados por produtores | -                                              | JSON                | JWT Token                  |
| /api/farmers/products                   | POST   | Cadastrar um novo produto                      | -                                              | JSON                | JWT Token                  |
| /api/farmers/products/{product_id}      | GET    | Obter detalhes de um produto específico        | product_id (string)                             | JSON                | JWT Token                  |
| /api/farmers/products/{product_id}      | PUT    | Atualizar os detalhes de um produto específico | product_id (string)                             | JSON                | JWT Token                  |
| /api/farmers/products/{product_id}      | DELETE | Excluir um produto específico                  | product_id (string)                             | JSON                | JWT Token                  |
| /api/farmers/inventory                  | GET    | Obter o estoque de produtos do produtor       | -                                              | JSON                | JWT Token                  |
| /api/farmers/orders                     | GET    | Obter todos os pedidos feitos pelos revendedores | -                                              | JSON                | JWT Token                  |
| /api/retailers/products                 | GET    | Obter todos os produtos disponíveis para revenda | -                                              | JSON                | JWT Token                  |
| /api/retailers/orders                   | GET    | Obter todos os pedidos feitos pelos varejistas  | -                                              | JSON                | JWT Token                  |
