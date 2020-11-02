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

    changeHTMLlbl(response);

    autoInsertDataInInput(response);

    return response;
};

function changeHTMLlbl(user) {
    let accountStatus = document.getElementById("status");
    document.getElementById("userID").innerHTML = user[0].user.id;

    user[0].accountStatus ? accountStatus.innerHTML = "Ativo" : accountStatus.innerHTML = "Inativo";
}

async function updateUserData() {
    const inputValues = await getUserInputValue();
    const user = checkIfIsNull(inputValues);
    const id = getUserId();
    return fetch('https://localhost:44343/api/Users/' + id, {
        method: 'put',
        headers: headersConstruct(),
        body: JSON.stringify(user)
    }).then((response) => {
        if (response.status !== 204)
            errorUpdate();

        sucessUpdate();
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

async function getUserInputValue() {
    let email = document.getElementById("Email").value;
    let firstName = document.getElementById("FirstName").value;
    let lastName = document.getElementById("LastName").value;
    let socialName = document.getElementById("SocialName").value;
    let birth = document.getElementById("Birthday").value;

    const userInfo = await getUserInfo();

    const user = {
        Email: email, FirstName: firstName, LastName: lastName,
        SocialName: socialName, BirthDay: birth, Id: getUserId(),
        Password: userInfo[0].user.password, Role: "USER"
    };

    return user;
}

function autoInsertDataInInput(user) {
    let email = document.getElementById("Email").value = user[0].user.email;
    let firstName = document.getElementById("FirstName").value = user[0].user.firstName;
    let lastName = document.getElementById("LastName").value = user[0].user.lastName;
    let socialName = document.getElementById("SocialName").value;
    let birth = document.getElementById("Birthday").value = user[0].user.birthDay.slice(0, 10);
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

function sucessUpdate() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'Dados atualizados com sucesso',
        showConfirmButton: true,
        timer: 1500
    });
}

function errorUpdate() {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Erro ao atualizar os dados!',
        footer: 'verificar se as credeniais estão corretas'
    })
}

getUserId();
getUserInfo();