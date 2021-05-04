function GetAllSuperHeroes() {

    // My FIRST Javascript

    fetch(`https://localhost:44315/api/superheroDb`)
        .then(response => response.json())
        .then(result => {
            debugger;
            console.log(result[0]);
            document.querySelector('alias')
            document.querySelector('realName')
            document.querySelector('hideOut')
        });
    let heroesInput = document.querySelector('#Heroes').value;
    let heroes = {};
    let xhr = new XMLHttpRequest();
}

function AddSuperHero() {
    let xhr = new XMLHttpRequest();
    xhr.open('POST', '/api/superheroDb/', true);
    xhr.send();
}