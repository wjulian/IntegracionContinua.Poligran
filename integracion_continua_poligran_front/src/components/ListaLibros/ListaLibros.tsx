import React, { FC } from 'react';
import './ListaLibros.css';
import axios from 'axios';
import ILibro from '../../models/Libro';

interface ListaLibrosProps {
}

const librosPorDefecto: ILibro[] = [];

const ListaLibros: FC<ListaLibrosProps> = () => {
  const [libros, setLibros]: [ILibro[], (libros: ILibro[]) => void] = React.useState(librosPorDefecto);
  const [loading, setLoading]: [boolean, (loading: boolean) => void] = React.useState<boolean>(true);
  const [error, setError]: [string, (error: string) => void] = React.useState("");

  React.useEffect(() => {
    axios.get<ILibro[]>("http://localhost:5187/Libros", {
      headers: {
        "Content-Type": "application/json"
      }
    }).then(response => {
      setLibros(response.data);
      setLoading(false);
    }).catch(ex => {
      console.error(ex)
      // const error = ex.response.status === 404
      //   ? "Resource Not found"
      //   : "An unexpected error has occurred";
      setError(error);
      setLoading(false);
    });
  }, []);

  return (
    <div className="ListaLibros">
      <ul className="posts">
      {libros.map((libro) => (
          <li key={libro.id}>
            <img src={libro.imagen} alt="" />
            <h3>{libro.titulo}</h3>
            <p>{libro.autor}</p>
            <p>{libro.anioPublicacion}</p>
          </li>
   ))}
  </ul>
  {error && <p className="error">{error}</p>}
    </div>
  );
}


export default ListaLibros;
