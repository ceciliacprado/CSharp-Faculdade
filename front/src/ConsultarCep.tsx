import { useEffect } from "react";

function ConsultarCep(){

  useEffect(() => {
    //evento de carregamento do componente, para executar o código ao abrir e carregar o componente 
    //Axios - bibloteca de requisitção 

    fetch("https://viacep.com.br/ws/01001000/json/")
    .then(resposta => {
      return resposta.json(); 
    }) 
    .then((endereco) => {
      console.log(endereco); 
    }); 
  });

  return(
    <div>
    <h1>Consultar Cep</h1>
    <p></p>
    </div>
  );
}

export default ConsultarCep; 