import React from "react";
import "./dashboard.css";
import Sidebar from "../Sidebar";

function Dashboard() {
  const alunos = [
    {
      nome: "João da Silva",
      cpf: "123.456.789-00",
      curso: "Matemática",
      status: "Ativa",
    },
    {
      nome: "Maria Oliveira",
      cpf: "987.654.321-00",
      curso: "História",
      status: "A vencer",
    },
    {
      nome: "Ana Souza",
      cpf: "456.789.123-00",
      curso: "Ciências",
      status: "Ativa",
    },
    {
      nome: "Carlos Santos",
      cpf: "321.654.987-00",
      curso: "Português",
      status: "Vencida",
    },
    {
      nome: "Patrícia Ribeiro",
      cpf: "111.222.333-44",
      curso: "Física",
      status: "Ativa",
    },
  ];

  const getStatusClass = (status) => {
    switch (status) {
      case "Ativa":
        return "status status-ativa";
      case "A vencer":
        return "status status-avencer";
      case "Vencida":
        return "status status-vencida";
      default:
        return "status";
    }
  };

  return (
    <main className="dashboard">
      <Sidebar />

      <header className="dashboard-header">
        <h2>Dashboard</h2>
      </header>

      <section className="cards">
        <div className="card">
          <h3>120</h3>
          <p>Alunos Ativos</p>
        </div>
        <div className="card">
          <h3>8</h3>
          <p>Matrículas a vencer</p>
        </div>
        <div className="card">
          <h3>3</h3>
          <p>Matrículas vencidas</p>
        </div>
      </section>

      <section className="lista-alunos">
        <div className="lista-header">
          <h3>Lista de Alunos</h3>
        </div>
        <table>
          <thead>
            <tr>
              <th>Nome</th>
              <th>CPF</th>
              <th>Curso/Turma</th>
              <th>Situação da Matrícula</th>
            </tr>
          </thead>
          <tbody>
            {alunos.map((a, i) => (
              <tr key={i}>
                <td>{a.nome}</td>
                <td>{a.cpf}</td>
                <td>{a.curso}</td>
                <td>
                  <span className={getStatusClass(a.status)}>{a.status}</span>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </section>
    </main>
  );
}

export default Dashboard;
