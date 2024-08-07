    // GET METHOD
    async function get(event, tableName){ // returns a promise
        return new Promise(function (resolve, reject) {
            if (event)
                event.preventDefault();
            var loginURL = 'http://localhost:4000/' + tableName;
            fetch(loginURL, {METHOD: 'GET', headers:{'Content-Type':'application/json'},})
            .then(result => { 
                return result.json(); 
            })
            .then((result) => {
                console.log('in response: ', result);
                return resolve(result);
            })
            .catch(error => {
                console.log('error: ', error)
                return reject(error);
            });
        })
    }
    // POST METHOD
    async function post(event, tableName, ourBody){ // returns a promise
        return new Promise(function (resolve, reject) {
            if (event)
                event.preventDefault();
            var loginURL = 'http://localhost:4000/' + tableName;
            fetch(loginURL, {method: 'POST', 
                headers:{'Content-Type':'application/json'},
                body: ourBody // json in calling method
            })
            .then(result => { 
                return result.json(); 
            })
            .then((result) => {
                console.log('in response: ', result);
                return resolve(result);
            })
            .catch(error => {
                console.log('error: ', error)
                return reject(error);
            });
        })
    }
    // PUT METHOD (By ID)
    async function putByID(event, tableName, id, ourBody){ // returns a promise
        return new Promise(function (resolve, reject) {
            if (event)
                event.preventDefault();
            var loginURL = 'http://localhost:4000/' + tableName + '/' + id;
            fetch(loginURL, {method: 'PUT', 
                headers:{'Content-Type':'application/json'},
                body: ourBody // json in calling method
            })
            .then(result => { 
                return result.json(); 
            })
            .then((result) => {
                console.log('in response: ', result);
                return resolve(result);
            })
            .catch(error => {
                console.log('error: ', error)
                return reject(error);
            });
        })
    }
    // PUT METHOD (By Name)
    async function putByName(event, tableName, name, ourBody){ // returns a promise
        return new Promise(async function (resolve, reject) {
            if (event)
                event.preventDefault();
            var id = await nameToID(tableName, name);
            var loginURL = 'http://localhost:4000/' + tableName + '/' + id;
            fetch(loginURL, {method: 'PUT', 
                headers:{'Content-Type':'application/json'},
                body: ourBody // json in calling method
            })
            .then(result => { 
                return result.json(); 
            })
            .then((result) => {
                console.log('in response: ', result);
                return resolve(result);
            })
            .catch(error => {
                console.log('error: ', error)
                return reject(error);
            });
        })
    }

    // DELETE METHOD (By ID)
    async function deleteByID(event, tableName, id){ // returns a promise
        return new Promise(function (resolve, reject) {
            if (event)
                event.preventDefault();
            var loginURL = 'http://localhost:4000/' + tableName + '/' + id;
            fetch(loginURL, {method: 'DELETE', 
                headers:{'Content-Type':'application/json'}
            })
            .then(result => { 
                return result.json(); 
            })
            .then((result) => {
                console.log('in response: ', result);
                return resolve(result);
            })
            .catch(error => {
                console.log('error: ', error)
                return reject(error);
            });
        })
    }

    // DELETE METHOD (By Name)
    async function deleteByName(event, tableName, name){ // returns a promise
        return new Promise(async function (resolve, reject) {
            if (event)
                event.preventDefault();
            var id = await nameToID(tableName, name);
            var loginURL = 'http://localhost:4000/' + tableName + '/' + id;
            fetch(loginURL, {method: 'DELETE', 
                headers:{'Content-Type':'application/json'}
            })
            .then(result => { 
                return result.json(); 
            })
            .then((result) => {
                console.log('in response: ', result);
                return resolve(result);
            })
            .catch(error => {
                console.log('error: ', error)
                return reject(error);
            });
        })
    }
    
    // Helper Method
    async function nameToID(tablename, name){ // returns ID of name in tablename
        let names = []
        await get(event, tablename).then(async response => {
            for(var i = 0; i < response.length; i++){
                if (response[i].name == name)
                    return response[i].id;
            }
        })
    }

    // Redirect
    function redirect(path){
        window.location.href = path;
    }


    // Start of DB verification functionality (Appending default values to DB)

    function verifyDB(){ // appends default entries to DB
        verifyItems();
        verifyClasses();
    }

    const defaultItems = [
        {
            "name":"DevWep",
            "weight":0.5,
            "value":1,
            "typeOfItem":"melee weapon"
        },
    ]
    async function verifyItems(){ // appends defaults
        let names = []
        await get(event, 'items').then(async response => {
            for(var i = 0; i < response.length; i++){
                names.push(response[i].name);
            }
            for (var j = 0; j < defaultItems.length; j++){
                if (!names.includes(defaultItems[j].name)){
                    try{
                        console.log(defaultItems[j].name + " was not found, appending...");
                        await post(event,'items',defaultItems[i]);
                    } catch (err) {
                        console.log('verifydb error: ', err);
                    }
                }
            }
            console.log("Item verification complete.")
        })
    }

    const defaultClasses = [
        {
            "className":"Wizard",
            "dex":1,
            "str":1,
            "wis":1,
            "magic":1,
            "magicResist":1
        },
    ]
    async function verifyClasses(){ // appends defaults
        let names = []
        await get(event, 'characterclasses').then(async response => {
            for(var i = 0; i < response.length; i++){
                names.push(response[i].name);
            }
            for (var j = 0; j < defaultClasses.length; j++){
                if (!names.includes(defaultClasses[j].name)){
                    try{
                        console.log(defaultClasses[j].name + " was not found, appending...");
                        await post(event,'classes',defaultClasses[i]);
                    } catch (err) {
                        console.log('verifydb error: ', err);
                    }
                }
            }
            console.log("Class verification complete.")
        })
    }