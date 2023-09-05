# Trade-offs de Características de Qualidade

Pré-requisitos:<a href="funcionalidades.md"> Funcionalidades</a>

As categorias de requisitos não-funcionais para o produto de software "FocusFlow", conforme o modelo FURPS+, seriam:

1. **Usabilidade**: 
   
   a. O sistema deve ser simples de usar, com uma interface intuitiva e acessível, onde para realizar ações, os usuários não necessitem de assessoria extra após o treinamento inicial para uso do software.

   b. O sistema deve responder de forma clara e intuitiva a erros de usuários.

2. **Desempenho**: 
   
   a. O sistema deve ser capaz de lidar com um grande número de usuários e transações simultâneas sem comprometer o desempenho, permitindo que a resposta a qualquer diálogo, não exceda a 3 segundos.

   b. O sistema deve ter a escalabilidade horizontal por meio de desacoplamento, através da implementação de APIs RESTful.

3. **Confiabilidade**: 
   
   a. O sistema deve ter mecanismos para conter falhas, garantindo a recuperação de dados, e assegurar uma disponibilidade de 99,9%, o que significa que ele não deve exceder 8,76 horas de inatividade por ano.
   
   b. O sistema deve propor autenticação de usuários para ter acessibilidade as configurações pessoais e tarefas, propondo um sistema confiável, como a autenticação em dois fatores. No que se refere à segurança, após a terceira tentativa de login falho, o usuário é bloqueado provisoriamente com a finalidade de evitar tentativas desgastantes aos usuários. Como um agregador de confiabilidade, as senhas deverão ser armazenadas com segurança usando o método hash e sal.

   c. O sistema deverá garantir que o processo de Backup esteja funcionando e que em decorrer de queda de rede, ele deve recuperar os dados já importados e continuar a partir do ponto em que ocorreu a falha. 

4. **Suportabilidade**: 
   
   a. A instalação do software deve ser realizada de forma semiautomática, com o mínimo de intervenção humana.

   b. O sistema deve rodar a partir dos principais navegadores existentes.

   c. O sistema deve ser projetado visando proporcionar atualizações e manutenções, possibilitando que todas as solicitações de suporte sejam atendidas em um decurso de no máximo 36 horas corridas.

A importância relativa de cada categoria:

| Categoria | Usabilidade | Desempenho | Confiabilidade | Suportabilidade |
| --- | --- | --- | --- | --- |
| Usabilidade | - | > | > | > |
| Desempenho | < | - | < | > |
| Confiabilidade | < | > | - | > |
| Suportabilidade | < | < | < | - |

> Nesta matriz, o sinal ">" indica que a categoria da linha é mais importante que a categoria da coluna, e o sinal "<" indica que a categoria da linha é menos importante que a categoria da coluna. Por exemplo, a Usabilidade é considerada mais importante que o Desempenho, Confiabilidade e Suportabilidade, enquanto o Desempenho é considerado mais importante que a Suportabilidade, mas menos importante que a Usabilidade e Confiabilidade, e assim por diante.

[Retorna](../README.md)
