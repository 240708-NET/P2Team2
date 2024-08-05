    function get(event){
        event.preventDefault();
        var loginURL = 'http://localhost:4000/items';
        fetch(loginURL, {METHOD: 'GET', headers:{'Content-Type':'application/json'},})
        .then(result => { 
            return result.json(); 
        })
        .then((result) => {
                console.log('in response: ', result);
        })
        .catch(error => {
            console.log('in fetch error: ', error)
        });
    }


    async function get_2(event) {
        event.preventDefault();
        try{
            const response = await fetch('http://localhost:4000/Items');
            if(!response.ok){
                throw new Error('something went wrong');
            }
            const data = await response.json();
            console.log(data);
        }
        catch(err){
            console.error(err);
        }
    }