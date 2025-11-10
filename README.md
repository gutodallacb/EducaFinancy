# EducaFinancy

Plataforma de gestão educacional com foco em controle financeiro e administração de alunos, cursos, matrículas e turmas.

## Tecnologias

- Back-end: .NET 8 (WebAPI)
- Front-end: React + Vite
- Banco de dados: a definir (ex: SQL Server / SQLite / PostgreSQL)

## Estrutura do Projeto

- Educafinancy.Api → API em .NET 8
- educafinancy.client → Front-end em React + Vite

## Como Rodar

**API .NET:**

cd Educafinancy.Api  
dotnet run

**Front-end React:**

cd educafinancy.client  
npm install  
npm run dev

A aplicação abrirá em http://localhost:5173/  
A API abrirá em https://localhost:7240/ (ou a porta retornada pelo .NET)

## Funcionalidades Planejadas

- Cadastro de alunos  
- Cadastro de cursos  
- Matrículas  
- Turmas  
- Dashboard financeiro  
