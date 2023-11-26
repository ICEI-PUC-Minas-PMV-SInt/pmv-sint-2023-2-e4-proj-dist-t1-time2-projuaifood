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

# Especificação de APIs para o UaiFood

| Endpoint                                | Método | Descrição                                           | Parâmetros                                 | Formato da Resposta | Autenticação e Autorização |
|-----------------------------------------|--------|-----------------------------------------------------|--------------------------------------------|---------------------|----------------------------|
| /api/users                             | GET    | Obter todos os clientes cadastrados                | N/A                                        | JSON                | N/A                        |
| /api/users/{user_id}                   | GET    | Obter detalhes de um cliente específico            | user_id (int)                             | JSON                | N/A                        |
| /api/users/{user_id}                   | PUT    | Atualizar os detalhes de um cliente específico     | user_id (int)                             | JSON                | JWT Token                  |
| /api/users/{user_id}/orders            | GET    | Obter todos os pedidos de um cliente específico    | user_id (int)                             | JSON                | JWT Token                  |
| /api/orders                            | GET    | Obter todos os pedidos                             | N/A                                        | JSON                | N/A                        |
| /api/orders/{order_id}                | GET    | Obter detalhes de um pedido específico             | order_id (int)                            | JSON                | JWT Token                  |
| /api/orders                           | POST   | Criar um novo pedido                               | N/A                                        | JSON                | JWT Token                  |
| /api/orders/{order_id}               | PUT    | Atualizar os detalhes de um pedido específico      | order_id (int)                            | JSON                | JWT Token                  |
| /api/orders/{order_id}               | DELETE | Excluir um pedido específico                      | order_id (int)                            | JSON                | JWT Token                  |
| /api/orders/{order_id}/products      | GET    | Obter todos os produtos de um pedido específico   | order_id (int)                            | JSON                | JWT Token                  |
| /api/products                         | GET    | Obter todos os produtos                            | N/A                                        | JSON                | N/A                        |
| /api/products/{product_id}           | GET    | Obter detalhes de um produto específico            | product_id (int)                          | JSON                | N/A                        |
| /api/producers                         | GET    | Obter todos os produtores                           | N/A                                        | JSON                | N/A                        |
| /api/producers/{producer_id}         | GET    | Obter detalhes de um produtor específico           | producer_id (int)                         | JSON                | N/A                        |
| /api/users/{user_id}/cart           | GET    | Obter o carrinho de compras de um cliente específico | user_id (int)                           | JSON                | JWT Token                  |
| /api/users/{user_id}/cart/{product_id} | POST   | Adicionar um produto ao carrinho de compras         | user_id (int) product_id (int)          | JSON                | JWT Token                  |
| /api/users/{user_id}/cart/{product_id} | DELETE | Remover um produto do carrinho de compras          | user_id (int) product_id (int)          | JSON                | JWT Token                  |

