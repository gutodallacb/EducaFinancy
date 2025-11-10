import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "./login.css";

function Login() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    if (username === "admin" && password === "123") {
      navigate("/Dashboard");
    } else {
      setError("Usuário ou senha incorretos.");
    }
  };

  return (
    <div className="login-container">
      <div className="login-card">
        <h1 className="login-title">EducaFincancy</h1>
        <p className="login-subtitle">Acesse sua conta</p>

        <form onSubmit={handleSubmit}>
          <div className="input-group">
            <label>Usuário</label>
            <input
              type="text"
              placeholder="Digite seu usuário"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
              required
            />
          </div>

          <div className="input-group">
            <label>Senha</label>
            <input
              type="password"
              placeholder="Digite sua senha"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </div>

          {error && <p className="error-message">{error}</p>}

          <button type="submit" className="login-btn">
            Entrar
          </button>
        </form>

        <p className="login-footer">github.com/gutodallacb</p>
      </div>
    </div>
  );
}

export default Login;
