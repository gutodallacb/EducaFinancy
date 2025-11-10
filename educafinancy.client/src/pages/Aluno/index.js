import React, { useState } from "react";
import Sidebar from "../Sidebar";
import "./aluno.css";

function Alunos() {
  const [aluno, setAluno] = useState({
    Nome: "",
    Sobrenome: "",
    Data_Nascimento: "",
    CPF: "",
    Email: "",
    Telefone: "",
    Endereco: "",
    Nome_Mae: "",
    Nome_Pai: "",
  });

  function handleChange(e) {
    const { name, value } = e.target;
    setAluno({ ...aluno, [name]: value });
  }

  async function handleSubmit(e) {
    e.preventDefault();

    try {
      const response = await fetch("https://localhost:5299/api/Aluno", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(aluno),
      });

      if (!response.ok) {
        throw new Error("Erro ao cadastrar aluno");
      }

      const data = await response.json();
      alert("Aluno cadastrado com sucesso!");
      console.log("Aluno cadastrado:", data);

      setAluno({
        Nome: "",
        Sobrenome: "",
        Data_Nascimento: "",
        CPF: "",
        Email: "",
        Telefone: "",
        Endereco: "",
        Nome_Mae: "",
        Nome_Pai: "",
      });
    } catch (error) {
      console.error("Erro ao cadastrar aluno:", error);
      alert("Erro ao cadastrar aluno!");
    }
  }

  return (
    <div className="cadastro-aluno">
      <Sidebar />

      <div className="conteudo-principal">
        <h2>Cadastro de Aluno</h2>

        <form onSubmit={handleSubmit} className="form-aluno">
          <div className="form-group">
            <label>Nome:</label>
            <input
              type="text"
              name="Nome"
              value={aluno.Nome}
              onChange={handleChange}
              required
            />
          </div>

          <div className="form-group">
            <label>Sobrenome:</label>
            <input
              type="text"
              name="Sobrenome"
              value={aluno.Sobrenome}
              onChange={handleChange}
              required
            />
          </div>

          <div className="form-group">
            <label>Data de Nascimento:</label>
            <input
              type="date"
              name="Data_Nascimento"
              value={aluno.Data_Nascimento}
              onChange={handleChange}
              required
            />
          </div>

          <div className="form-group">
            <label>CPF:</label>
            <input
              type="text"
              name="CPF"
              value={aluno.CPF}
              onChange={handleChange}
              required
            />
          </div>

          <div className="form-group">
            <label>Email:</label>
            <input
              type="email"
              name="Email"
              value={aluno.Email}
              onChange={handleChange}
            />
          </div>

          <div className="form-group">
            <label>Telefone:</label>
            <input
              type="text"
              name="Telefone"
              value={aluno.Telefone}
              onChange={handleChange}
            />
          </div>

          <div className="form-group">
            <label>Endereço:</label>
            <input
              type="text"
              name="Endereco"
              value={aluno.Endereco}
              onChange={handleChange}
            />
          </div>

          <div className="form-group">
            <label>Nome da Mãe:</label>
            <input
              type="text"
              name="Nome_Mae"
              value={aluno.Nome_Mae}
              onChange={handleChange}
            />
          </div>

          <div className="form-group">
            <label>Nome do Pai:</label>
            <input
              type="text"
              name="Nome_Pai"
              value={aluno.Nome_Pai}
              onChange={handleChange}
            />
          </div>

          <button type="submit" className="btn-cadastrar">
            Cadastrar
          </button>
        </form>
      </div>
    </div>
  );
}

export default Alunos;
