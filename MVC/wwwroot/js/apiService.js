function getUserId() {
    const id = parseJwt(getCookie('jwt')).unique_name;
    return id;
}

async function getUserInfo() {
    const id = getUserId();
    const response = await fetch('https://localhost:44343/api/Customers/' + id, {
        method: 'get',
        headers: headersConstruct(),
    }).then(response => response.json());

    return response;
};


function headersConstruct() {
    const token = getCookie('jwt');
    const headers = new Headers({
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        'Authorization': 'Bearer ' + token
    });

    return headers;
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