async function getUserId() {
    const id = parseJwt(getCookie('jwt')).unique_name;
    document.getElementById("userID").innerHTML = id;
    const user = await getUserInfo();
    //console.log(user);

    return id;
}

async function getUserInfo() {
    const id = getUserId();
    const response = await fetch('https://localhost:44343/api/Users/' + id, {
        method: 'get',
        headers: headersConstruct(),
    }).then(response => response.json());

    return response;
};

function updateUserData() {
    const user = checkIfIsNull(getUserInputValue());
    const id = getUserId();
    return fetch('https://localhost:44343/api/Users/' + id , {
        method: 'put',
        headers: headersConstruct(),
        body: JSON.stringify(user)
    }).then((response) => {
        console.log(response.status)
    });
}

function headersConstruct() {
    const token = getCookie('jwt');
    const headers = new Headers({
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + token
    });

    return headers;
}

function getUserInputValue() {
    let email = document.getElementById("Email").value;
    let firstName = document.getElementById("FirstName").value;
    let lastName = document.getElementById("LastName").value;
    let socialName = document.getElementById("SocialName").value;
    let birth = document.getElementById("Birthday").value;

    const user = {
        Email: email, FirstName: firstName, LastName: lastName,
        SocialName: socialName, BirthDay: birth, Id: getUserId(),
        Password: "passWORLD", Role: "USER"
    };

    return user;
}

function getCookie(name) {
    let cookie = {};
    document.cookie.split(';').forEach(function (el) {
        let [k, v] = el.split('=');
        cookie[k.trim()] = v;
    })
    return cookie[name];
}

function parseJwt(token) {
    var base64Url = token.split('.')[1];
    var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    var jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
        return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
    }).join(''));

    return JSON.parse(jsonPayload);
};

function checkIfIsNull(obj) {
    for (var key in obj) {
        if (obj[key] == null || obj[key] == "")
            obj[key] = "null";
    }
    return obj;
}

getUserId();