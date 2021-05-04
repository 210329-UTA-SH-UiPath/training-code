function GetAllSuperHeroes(){
    let APILink = `https://localhost:44315/api/SuperHero`;
    let superHeros = {};
    let xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            superHeros = JSON.parse(xhr.responseText);
            let SuperHerosTableBody = document.querySelector('#heroes tbody');

            json.forEach(function (obj) {
                console.log(obj.Id);
                let newRow = heroTBody.insertRow();

                let newCell = newRow.insertCell();
                let newText = document.createTextNode(`${obj.RealName}`);
                newCell.appendChild(newText);

                newCell = newRow.insertCell();
                newText = document.createTextNode(`${obj.Alias}`);
                newCell.appendChild(newText);

                newCell = newRow.insertCell();
                newText = document.createTextNode(`${obj.HideOut}`);
                newCell.appendChild(newText);
            });
        }
    };

    xhr.open('GET', 'https://localhost:44315/api/superheroDb/', true);
    xhr.send();
}

function AddSuperHero() {
    let realNameInput = document.querySelector('#realName').value;
    let aliasInput = document.querySelector('#alias').value;
    let hideOutInput = document.querySelector('#hideOut').value;
    let xhr = new XMLHttpRequest();
    let url = "submit.php";

    xhr.open("POST", 'https://localhost:44315/api/superheroDb/', true);
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            result.innerHTML = this.responseText
        }
    };

    var data = JSON.stringify({ "RealName": realNameInput, "Alias": aliasInput, "HideOut": hideOutInput });
    xhr.send(data);
}