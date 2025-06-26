# Construindo um Projeto Ágil no GitHub: Da Gestão ao Controle de Qualidade

## 1. Objetivo do Projeto

Este projeto tem como objetivo principal desenvolver um sistema de gerenciamento de tarefas utilizando metodologias ágeis e as ferramentas de gestão de projetos disponíveis no GitHub. Atuando como desenvolvedor e gestor de projetos, o foco é simular um ambiente de desenvolvimento real, aplicando conceitos de Engenharia de Software para planejar, criar e gerenciar um repositório que demonstre todo o ciclo de vida do software.

O sistema visa permitir o acompanhamento do fluxo de trabalho em tempo real, a priorização de tarefas e o monitoramento do desempenho da equipe, conforme solicitado por um cliente fictício, uma startup de logística.

## 2. Escopo do Sistema

O sistema de gerenciamento de tarefas será um **CRUD (Create, Read, Update, Delete) básico de tarefas**. As funcionalidades principais incluem:

* **Criar Tarefa:** Adicionar novas tarefas com informações como título, descrição, status e, opcionalmente, data de vencimento.
* **Visualizar Tarefas:** Exibir uma lista de todas as tarefas cadastradas, permitindo uma visão geral do trabalho.
* **Atualizar Tarefa:** Modificar os detalhes de uma tarefa existente, como status (A Fazer, Em Progresso, Concluído).
* **Deletar Tarefa:** Remover tarefas que não são mais necessárias.

## 3. Metodologia Adotada: Kanban

A metodologia ágil adotada para a gestão deste projeto é o **Kanban**. Utilizarei a aba **"Projects"** do GitHub para criar um quadro visual de tarefas, facilitando a organização e o acompanhamento do fluxo de trabalho.

### Quadro Kanban

O quadro Kanban será dividido nas seguintes colunas:

* **A Fazer:** Contém todas as tarefas pendentes que ainda não foram iniciadas.
* **Em Progresso:** Inclui as tarefas nas quais o desenvolvimento está atualmente ativo.
* **Concluído:** Abriga as tarefas que foram finalizadas e testadas.

Este modelo permite uma visualização clara do status de cada item, otimizando a gestão do tempo e a organização das atividades.

## 4. Tecnologias Utilizadas

- ASP.NET Core 9.0
- Blazor
- Entity Framework Core
- Bootstrap
- Bootstrap icons
- Visual Studio 2022+

## 5. Instruções para Execução do Sistema

### Pré-requisitos

Antes de iniciar, certifique-se de que você tenha instalado:

- [.NET SDK 9.0](https://dotnet.microsoft.com/pt-br/download) 
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/), com os workloads:
  - ASP.NET e desenvolvimento web
  - Desenvolvimento com Blazor

### ⚙️ Clonando o Repositório

```bash
git clone https://github.com/RonaldRonan14/GestaoControleQualidade.git
cd GestaoControleQualidade
```

### Estrutura do Projeto

O projeto principal está localizado em:

```
GestaoControleQualidade/GestaoControleQualidade.sln
```

### Executando a Aplicação

No Visual Studio:

1. Defina o projeto `GestaoControleQualidade` como projeto de inicialização.
2. Pressione `F5` ou clique em **Iniciar Depuração**.

Via terminal:

```bash
cd GestaoControleQualidade/GestaoControleQualidade
dotnet run
```

A aplicação será iniciada e estará disponível em: [https://localhost:7001](https://localhost:7001) 
