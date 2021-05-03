function GetPokemon(){
    let pokemonInput=document.querySelector('#PokemonId').value;//grab the text field valie
    let pokemon={};// object to recieve the pokemon
    //1. create the Request
    let xhr=new XMLHttpRequest();// this obj is going to make server side calls
    //the ready state of the xhttp object determines the state of the request:
    // 0 - uninitialized
    // 1 - loading (server connection established) the open method has been invoked
    // 2 - loaded (request received by server) send has been called
    // 3 - interactive (processing request) response body is being received
    // 4 - complete (response received) 
    // the status code checks if the operation is successful
    //2. Handle the response
    xhr.onreadystatechange=function(){
        if(this.readyState== 4 && this.status == 200){
            pokemon=JSON.parse(xhr.responseText);// this function will convert the response receive to JS object
            document.querySelector('.pokemonResult img').setAttribute('src', pokemon.sprites.front_default);
            document.querySelectorAll('.pokemonResult caption').forEach((element)=>element.remove());
            let caption= document.createElement('caption');
            let pokeName= document.createTextNode(pokemon.forms[0].name);
            console.log(pokeName.value);
            caption.appendChild(pokeName);
            document.querySelector('.pokemonResult').appendChild(caption);
            document.querySelector('#PokemonId').value='';
        }
    };
    //3. Make the request
    xhr.open('GET',`https://pokeapi.co/api/v2/pokemon/${pokemonInput}`,true);
    //4. Send the Request
    xhr.send();
}

function GetDigimon(){
    let digimonName=document.querySelector('#digimonInput').value;
    fetch(`https://digimon-api.vercel.app/api/digimon/name/${digimonName}`)
    .then(response=>response.json())
    .then(result=>{
        debugger;
        console.log(result[0]);
        document.querySelector('.digimonResult img').setAttribute('src', result[0].img);
        document.querySelectorAll('.digimonResult caption').forEach((element)=>element.remove());
        let caption = document.createElement('caption');
        caption.appendChild(document.createTextNode(result[0].name));
        document.querySelector('.digimonResult').appendChild(caption);
        document.querySelector('#digimonInput').value="";
    });
}