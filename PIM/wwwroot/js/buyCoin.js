function getUserId() {
    const id = parseJwt(getCookie('jwt')).unique_name;
    return id;
}

function parseJwt(token) {
    var base64Url = token.split('.')[1];
    var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    var jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
        return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
    }).join(''));

    return JSON.parse(jsonPayload);
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

async function checkout() {
    let select = document.getElementById('select').value;
    let money = document.getElementById('money').value;
    const value = buyCoin(select, money)
    increaseWallet(value);
    clearInputs();

}

function buyCoin(select, money) {
    const finalValue = money / select;
    if (money < 100 || select == null)
        return alert(`VALOR INVALIDADO`);
    else {
        alert(`O valor final deu ${finalValue}`)
        return finalValue;
    }
}

async function getWallet() {
    const id = getUserId();
    const response = await fetch('https://localhost:44343/api/Customers/Wallet/' + id, {
        method: 'get',
        headers: headersConstruct(),
    }).then(response => response.json());

    console.log(response[0]);

    return response[0];
};


async function increaseWallet(value) {
    const walletInfo = await getWallet();
    console.log(walletInfo);
    const wallerPut = { walletId: walletInfo.walletId, walletBalance: (walletInfo.walletBalance + value) }
    const response = await fetch('https://localhost:44343/api/Wallets/' + walletInfo.walletId, {
        method: 'put',
        headers: headersConstruct(),
        body: JSON.stringify(wallerPut)
    }).then((response) => {
        if (response.status !== 204)
            console.log('error')
    });
}

function clearInputs() {
    document.getElementById('money').value = "";
}