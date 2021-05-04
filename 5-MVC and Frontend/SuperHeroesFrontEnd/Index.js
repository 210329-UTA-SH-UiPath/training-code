// "https://localhost:44315/api/superheroDb/"

function GetAllSuperHeroes() {
    fetch(`https://localhost:44315/api/superheroDb`)
        .then(response => response.json())
        .then(result => {
            debugger;
            console.log(result[0]);
            let caption = document.createElement('caption');
            caption.appendChild(document.createTextNode(result[0].RealName));
            caption.appendChild(document.createTextNode(result[0].HideOut));
            document.querySelector('#heroes').appendChild(caption);
        });
}

function AddSuperHero(){
    const http = new XML();
    const url = `https://localhost:44315/api/superheroDb/`;
    http.open("POST", url);
    const sp = {
        Id: 0,
        Name: "Fire",
        Description: 'ShootFire',
    }
    const data = {
        Id: 0,
        RealName: "Regis",
        Alias: 'The hedgehog',
        HideOut: "House",
        SuperPower: sp
    }
    http.send(url, data);
}