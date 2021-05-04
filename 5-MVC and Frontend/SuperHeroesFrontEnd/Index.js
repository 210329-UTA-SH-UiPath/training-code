function GetAllHeroes(){

	fetch('https://localhost:44315/api/superherodb')
  .then(
    function(response) {
      if (response.status !== 200) {
        console.log('Looks like there was a problem. Status Code: ' +
          response.status);
        return;
      }

      // Examine the text in the response
      response.json().then(function(data) {
       
	   		let table = document.querySelector("#heroes")
		for (let i = 0; i < data.length; ++i)
		{
			let tr = table.insertRow(-1);
			
			let tdRealName = tr.insertCell(-1);
			let tdAlias    = tr.insertCell(-1);
			let tdHideout  = tr.insertCell(-1);
			
			tdRealName.textContent = data[i]["realName"];
			tdAlias.textContent    = data[i]["alias"];
			tdHideout.textContent  = data[i]["hideOut"];
		}
	   
	   
      });
    }
  )
  .catch(function(err) {
    console.log('Fetch Error :-S', err);
  });
	
}

function AddAHero(){
	// TODO: also add error handling here
	fetch("https://localhost:44315/api/superherodb", {
		method: "post",
		headers: new Headers({
			'Content-Type': 'application/json'
		}),
		body: JSON.stringify({
			realName: document.querySelector("#realName").value,
			alias: document.querySelector("#alias").value,
			hideOut: document.querySelector("#hideOut").value
		})
	});
}