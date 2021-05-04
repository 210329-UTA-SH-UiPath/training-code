function GetAllSuperHeroes() {
    var table = document.querySelector('#heroes');

    fetch('https://localhost:44315/api/superheroDb/')
        .then(response => response.json())
        .then(result => {
            for (let i = 0; i < result.length; ++i) {
                let row = table.insertRow();
                row.insertRow().appendChild(document.createTextNode(result[x].RealName));
                row.insertRow().appendChild(document.createTextNode(result[x].Alias));
                row.insertRow().appendChild(document.createTextNode(result[x].HideOut));
            })
}

function AddAHero() {
    let name = document.querySelector('#realName').value;
    let alias = document.querySelector('#alias').value;
    let hideOut = document.querySelector('#hideOut').value;

    var heroObj = { RealName: name, Alias: alias, HideOut: hideOut };

    fetch('https://localhost:44315/api/superheroDb/', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(hero),
    })
        .then(response => response.json())
        .then(heroObj => {
            console.log('Success:', heroObj);
        })
        .catch((error) => {
            console.error('Error:', error);
        });

}