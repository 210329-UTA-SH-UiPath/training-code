function GetAllSuperHeroes() {

    //write your logic here
    let superheroes = {};// object to recieve the pokemon
    //1. create the Request
    let xhr = new XMLHttpRequest();// this obj is going to make server side calls
    //the ready state of the xhttp object determines the state of the request:
    // 0 - uninitialized
    // 1 - loading (server connection established) the open method has been invoked
    // 2 - loaded (request received by server) send has been called
    // 3 - interactive (processing request) response body is being received
    // 4 - complete (response received) 
    // the status code checks if the operation is successful
    //2. Handle the response
    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            superheroes = JSON.parse(xhr.responseText);// this function will convert the response receive to JS object
            let heroBody = document.querySelector('#heroBody');
            json.forEach(function (obj) {
                console.log(obj.Id);
                let newRow = heroBody.insertRow();

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

    //3. Make the request
    xhr.open('GET', 'https://localhost:44315/api/superheroDb/', true);
    //4. Send the Request
    xhr.send();
}

function AddSuperHero() {

    //write your logic here
    let realName = document.querySelector('#realName').value;
    let alias = document.querySelector('#alias').value;
    let hideOut = document.querySelector('#hideOut').value;

    let xhr = new XMLHttpRequest();
    let url = "submit.php";

    xhr.open("POST", 'https://localhost:44315/api/superheroDb/', true);

    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            result.innerHTML = this.responseText
        }
    };

    var data = JSON.stringify({ "RealName": realName, "Alias": alias, "HideOut": hideOut });

    xhr.send(data);
} 