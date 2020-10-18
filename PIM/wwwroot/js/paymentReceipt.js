function getUserId() {
    const id = parseJwt(getCookie('jwt')).unique_name;
    return id;
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

async function getUserInfo() {
    const id = getUserId();
    const response = await fetch('https://localhost:44343/api/Customers/' + id, {
        method: 'get',
        headers: headersConstruct(),
    }).then(response => response.json());

    changeHTMLlbl(response);

    return response;
};

function changeHTMLlbl(user) {
    const contracts = user[0].contracts;
    console.log(contracts);
}

function parseJwt(token) {
    var base64Url = token.split('.')[1];
    var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    var jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
        return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
    }).join(''));

    return JSON.parse(jsonPayload);
}

function getCookie(name) {
    let cookie = {};
    document.cookie.split(';').forEach(function (el) {
        let [k, v] = el.split('=');
        cookie[k.trim()] = v;
    })
    return cookie[name];
}
getUserInfo();