async function GetAllHeroes() {

    //write your logic here
    let superHeroes;
    let url = 'https://localhost:5001/api/SuperHero';
    let init = {
        method: 'GET',
        mode: 'no-cors',
        headers: {
            'Content-Type': 'application/json'
        }
    };
    fetch(url, init)
        .then(response => response.json())
        .then(result => {
            alert(result);
        });
    /*
    let tbody = document.querySelector(".container table tbody");
    tbody.innerHTML("");
    superHeros.forEach(hero => {
        tbody.append("<tr><td>"
            + hero.realName
            + hero.alias
            + hero.hideOut
            + "</td></tr>");
    });
    */
}

function AddAHero() {
    //write your logic here
    alert("superHeroes");
}