function GetAllHeroes(){

    var table = document.querySelector('#heroes');

    fetch('https://localhost:44315/api/superheroDb/')
        .then(response => response.json())
        .then(result => {
            for (let i = 0; i < result.length; i += 1) {
                let row = table.insertRow();
                row.insertRow().appendChild(document.createTextNode(result[x].RealName));
                row.insertRow().appendChild(document.createTextNode(result[x].Alias));
                row.insertRow().appendChild(document.createTextNode(result[x].HideOut));
            }
        });
    
}

function AddAHero() {
    let name = document.querySelector('#realName').value;
    let alias = document.querySelector('#alias').value;
    let hideout = document.querySelector('#hideout').value;
    let hero = { RealName: name, Alias: alias, HideOut: hideout };

    fetch('https://localhost:44315/api/superheroDb/', {
        method: 'POST', 
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(hero),
    })
        .then(response => response.json())
        .then(hero => {
            console.log('Success:', hero);
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}