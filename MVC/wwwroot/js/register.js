async function register() {
    const user = getHtmlElementsOfUser();
    const resonse = await fetch('https://localhost:44343/api/Users/Register', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    }).then((response) => {
        if (!response.ok) {
            console.log('error');
        }
        return response.json();
    }).then((data) => {
        const address = getHtmlElementsOfaddress(data.id);
        createAddress(address);
        createCustomer(data.id);
    });

    return resonse;
}

function getHtmlElementsOfUser() {
    let firstName = document.getElementById("firstName").value;
    let lastName = document.getElementById("lastName").value;
    let socialName = document.getElementById("socialName").value;
    let birthDay = document.getElementById("birth").value;
    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;

    const user = {
        firstName: firstName, lastName: lastName, socialName: socialName,
        birthDay: birthDay, email: email, password: password
    };

    return user;
}

function getHtmlElementsOfaddress(userId) {
    let publicArea = document.getElementById("publicArea").value;
    let streetNumber = document.getElementById("streetNumber").value;
    let city = document.getElementById("city").value;
    let neighborhood = document.getElementById("neighborhood").value;
    let zipCode = document.getElementById("zipCode").value;

    const address = {
        publicArea: publicArea, streetNumber: streetNumber, city: city,
        neighborhood: neighborhood, zipCode: zipCode, userId: userId
    }

    return address;
}

function checkIfAgeIsValid(age) {
    return age < 18 ? false : true;
}

function getAge(dateString) {
    var today = new Date();
    var birthDate = new Date(dateString);
    var age = today.getFullYear() - birthDate.getFullYear();
    var m = today.getMonth() - birthDate.getMonth();
    if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
        age--;
    }
    return age;
}

async function createAddress(address) {
    const response = await fetch('https://localhost:44343/api/Addresses', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(address)
    }).then(resp => resp.json()
    ).then((data) => {
        console.log(data)
        sucessRegister();
    })

    return response;
}

async function createCustomer(userId) {
    const User = { AccountStatus: true, UserId: userId }
    const response = await fetch('https://localhost:44343/api/Customers', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(User)
    }).then(resp => resp.json())
      .then((data) => {
          createWallet(data.custumerId)
      });

    return response;
}

async function createWallet(customerId) {
    console.log(customerId)
    const Wallet = { walletBalance: 0, customerId: customerId };
    fetch('https://localhost:44343/api/Wallets', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(Wallet)
    }).then(resp => resp.json()).then(data => console.log(data))
}

function sucessRegister() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'Cadastro feito com sucesso!',
        showConfirmButton: true,
        timer: 1500
    });

    location.replace("https://localhost:44345/Home/Login");
}

