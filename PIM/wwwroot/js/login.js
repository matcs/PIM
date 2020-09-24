const url = "https://localhost:44353/api/";

const myHeaders = new Headers({
    "Content-Type": "	application/json; charset=utf-8",
    'Accept': 'application/json, text/plain, */*'
});

function loginSubmit() {
    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;
    fetch(url + "Home/login", {
        method: "post",
        body: JSON.stringify({ email: email, password: password }),
        headers: myHeaders
    }).then((res) => {
        if (!res.ok) {
            return errorLogin();
        }
        return res.json()
    }).then((data) => {
        console.log(data.user);
        sessionStorage.setItem("token", data.beaver);
        sucessLogin();
        storeUser(data.user.personId);
    });
}

function sucessLogin() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'Login feito com sucesso',
        showConfirmButton: false,
        timer: 1500
    })
}

function errorLogin(){
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Email ou senha incorretos!',
        footer: 'verificar se as credeniais estão corretas'
    })
}

function storeUser(idUser) {
    fetch(url + `People/${idUser}`, {
        method: "get",
        headers: { 'authorization': `bearer ${sessionStorage.getItem('token')}` }
    }).then((res) => {        
        return res.json()
    }).then((data) => {
        console.log(data);

        localStorage.setItem("user", JSON.stringify(data));
        location.replace("https://localhost:44353/User/Dashboard");
    });
}