import "./sidebar.css";
import { FaUserGraduate, FaClipboardList, FaBook, FaClock, FaSignOutAlt } from "react-icons/fa";
import { useNavigate  } from "react-router-dom";

function Sidebar() {
  const navigate = useNavigate();

  return (
    <div className="sidebar">
      <h2 
        className="sidebar-title" 
        onClick={() => navigate("/Dashboard")}
        style={{ cursor: "pointer" }}
        >
        EducaFinancy
      </h2>

      <ul className="sidebar-menu">
        <li onClick={() => navigate("/Aluno")}>
          <FaUserGraduate className="icon" />
          <span>Aluno</span>
        </li>
        <li>
          <FaClipboardList className="icon" />
          <span>Matrícula</span>
        </li>
        <li>
          <FaBook className="icon" />
          <span>Curso</span>
        </li>
        <li>
          <FaClock className="icon" />
          <span>Turma</span>
        </li>
        <li onClick={() => navigate("/")}>
          <FaSignOutAlt className="icon" />
          <span>Sair</span>
        </li>
      </ul>
    </div>
  );
}

export default Sidebar;
