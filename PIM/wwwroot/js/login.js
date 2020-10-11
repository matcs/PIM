function Login() {
    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;

    const LoginInfo = { Email: email, Password: password }

    console.log(LoginInfo);

    fetch('https://localhost:44343/api/Users/Login', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(LoginInfo)
    }).then(function (response) {
        return response.json();
    }).then(function (data) {
        document.cookie = "jwt = " + data.beaver + "; path=/";
    });
}