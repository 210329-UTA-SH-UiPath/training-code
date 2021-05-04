function GetAllSuperHeroes() {
    let xhr = new XMLHttpRequest();
    xhr.open('GET', 'https://localhost:44315/api/superheroDb/', true);

    // request state change event
    xhr.onreadystatechange = function () {

        // request completed?
        if (xhr.readyState !== 4) return;

        if (xhr.status === 200) {
            // request successful - show response
            console.log(xhr.responseText);
        }
        else {
            // request error
            console.log('HTTP error', xhr.status, xhr.statusText);
        }
    };

    // start request
    xhr.send();
}

function AddSuperHero(superhero) {
    //write your logic here
    var xhr = new XMLHttpRequest();
    xhr.open("POST", 'https://localhost:44315/api/superheroDb/', true);

    //Send the proper header information along with the request
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () { // Call a function when the state changes.
        if (this.readyState === XMLHttpRequest.DONE && this.status === 200) {
            // Request finished. Do processing here.
        }
    }
    xhr.send(superhero);
}