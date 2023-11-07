import './App.css';
import ListaLibros from './components/ListaLibros/ListaLibros';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        {/* <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a> */}
        <h1>Libros disponibles</h1>
      </header>
      <main>
        <ListaLibros></ListaLibros>
      </main>
    </div>
  );
}

export default App;
