function GetAllHeroes() {
    let superheroes = {};

    let xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            superheroes = JSON.parse(xhr.responseText);
            document.querySelectorAll('#heroes tbody tr').forEach(element => element.remove());
            let heroTBody = document.querySelector('#heroes tbody');
            superheroes.forEach(function (obj) {
                console.log(obj.Id);
                let newRow = heroTBody.insertRow();

                let newCell = newRow.insertCell();
                newCell.innerHTML = obj.realName

                let newCell1 = newRow.insertCell();
                newCell1.innerHTML = obj.alias;

                let newCell2 = newRow.insertCell();
                newCell2.innerHTML = obj.hideOut;
            });
        }
    };

    xhr.open('GET', 'https://localhost:44315/api/superherodb', true);

    xhr.send();

}

function AddAHero() {
    let realNameInput = document.querySelector('#realName').value;
    let aliasInput = document.querySelector('#alias').value;
    let hideOutInput = document.querySelector('#hideOut').value;

    let xhr = new XMLHttpRequest();

    xhr.open("POST", 'https://localhost:44315/api/superherodb', true);

    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status > 199 && xhr.status < 300) {
            alert('New Hero Added');
            realNameInput.value = '';
            aliasInput.value = '';
            hideOutInput = '';
            GetAllHeroes();
        }
    };

    var data = JSON.stringify({ "realName": realNameInput, "alias": aliasInput, "hideOut": hideOutInput });

    xhr.send(data);
}