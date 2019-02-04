# URSALGamesCO

A prototype of cross-platform Game app

## About

This package contains a solution for managing / displaying the scores of users who play on our gaming platform. This solution consists of a back-end (.NET Core) and a front-end (Angular6).

Concepts used:
DDD

SOLID

Clean Code

## Installing/Running

You can build it from source.

Supported Compilers are:

Visual Studio 2017 with .NET Core support

Visual Studio Code

You need to install Git and Node.js < 8.x. (node.js is optional).

#### Step 1:

On Git Bash, clone this repository:
https://github.com/GregoryMiola/URSALGamesCO.git

#### Step 2:

In folder of our solution, open URSALGamesCO.sln and start the application.

#### Step 3:

You can access the exposed methods by http://localhost:56142/swagger/ui/index.html

#### Step 4 (OPTIONAL):

This solution has a front-end app, you can open the folder ./URSALGamesCO with Git Bash and run npm install and npm start for run by http://localhost:4200/. This solution can open on Visual Studio Code and can use all features of our solution.


## Requisito Opcional 3

Escalabilidade horizontal é a prática de remover/adicionar outros nós que respondem/responderão pela mesma aplicação e/ou seu ecosistema. Ele tem um custo menor que o vertical (mesmo nó), fácil manutenção e upgrade.

Para o nosso contexto, a proposta seria utilizar um serviço conceito no mercado (ex.: AWS) que realize esse tipo de serviço de forma prática. Caso tenhamos alguma infraestrutura disponível, poderiamos usar outros recursos que permitem essa escalabilidade, a exemplo de containers com docker. 
