function Login() {
    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;

    const LoginInfo = { Email: email, Password: password }

    fetch('https://localhost:44343/api/Users/Login', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(LoginInfo)
    }).then((response) => {
        if (!response.ok) {
            return errorUpdate();
        }
        console.log(response.json);
        return response.json();
    }).then((data) => {
        document.cookie = "jwt = " + data.beaver + "; path=/";
        sucessUpdate();
    });
}

function sucessUpdate() {
    Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'Login feito com sucesso',
        showConfirmButton: false,
        timer: 1500
    });

    location.replace("https://localhost:44345/User/News");
}

function errorUpdate() {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Email ou senha incorretos!',
        footer: 'verificar se as credeniais estão corretas'
    })
}