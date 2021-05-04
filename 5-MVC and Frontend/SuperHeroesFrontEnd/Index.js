function GetAllSuperHeroes() {

    //write your logic here
    let table = document.querySelector('#heroes').value;
    fetch(`https://localhost:44315/api/superheroDb/`)
        .then(response => response.json())
        .then(result => {
            debugger;
            for (let i = 0; i < result.length; i++) {
                let row = table.insertRow();
                row.appendChild(document.createTextNode(result[i].RealName));
                row.appendChild(document.createTextNode(result[i].Alias));
                row.appendChild(document.createTextNode(result[i].HideOut));
            }
        });
}

function AddSuperHero(){
    let realName = document.querySelector('#realName').value;
    let alias = document.querySelector('#alias').value;
    let hideOut = document.querySelector('#hideOut').value;
    const data { RealName: realname, Alias: alias, HideOut: hideOut}
    fetch('https://localhost:44315/api/superheroDb/', {
        method: 'POST', // or 'PUT'
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}