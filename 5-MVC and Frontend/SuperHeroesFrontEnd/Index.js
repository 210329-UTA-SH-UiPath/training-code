function GetAllSuperHeroes() {
    //write your logic here
    var table = document.querySelector('#heroes');

    fetch('https://localhost:44315/api/superheroDb/')
        .then(response => response.json())
        .then(result => {
            for (let x = 0; x < result.length; x++) {
                let newRow = table.insertRow();
                newRow.insertCell().appendChild(document.createTextNode(result[x].RealName));
                newRow.insertCell().appendChild(document.createTextNode(result[x].Alias));
                newRow.insertCell().appendChild(document.createTextNode(result[x].HideOut));
            }
        });
}

function AddSuperHero() {
    //write your logic here
    let name = document.querySelector('#realName').value;
    let alias = document.querySelector('#alias').value;
    let hideOut = document.querySelector('#hideOut').value;
    var data = { RealName: name, Alias: alias, HideOut: hideOut };

    fetch('https://localhost:44315/api/superheroDb/', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    }).then(response => response.json())
        .then(data => {
            console.log('Success:', data);
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}