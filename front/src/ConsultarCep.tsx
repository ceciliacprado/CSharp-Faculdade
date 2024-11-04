import { useEffect, useState } from "react";

function ConsultarCep(){

  const [localidade, setLocalidade] = useState(""); 
  const [estado, setEstado] = useState(""); 
  const [logradouro, setLogradouro] = useState(""); 
  const [cep, setCep] = useState(""); 

  useEffect(() => {
    //evento de carregamento do componente, para executar o código ao abrir e carregar o componente 
    //Axios - bibloteca de requisitção 

    fetch("https://viacep.com.br/ws/01001000/json/")
    .then((resposta) => resposta.json()) 
    .then((endereco) => {
     setLocalidade(endereco.localidade); 
     setEstado(endereco.estado);
     setLogradouro(endereco.logradouro);
    }); 
  });

  function digitar(event: any) {
    setCep(event.target.value); 
  }

  return(
    <div id="consultar_cep">
    <h1>Consultar Cep</h1>

    <input type="text" placeholder="Digite seu CEP" onChange={digitar} ></input>

    <p>{localidade}</p>
    <p>{estado}</p>
    <p>{logradouro}</p>
    <p>{cep}</p>
    </div>
  );
}

export default ConsultarCep; 