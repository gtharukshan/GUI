function toggleLoginForm() {
    const loginForm = document.getElementById("loginForm");
    loginForm.style.display = loginForm.style.display === "none" ? "block" : "none";
}


function handleLogin(event) {

    event.preventDefault();
    const username = document.getElementById('loginUsername').value.trim();
    const password = document.getElementById('loginPassword').value.trim();
    if (username === "admin" && password === "12345") {
        alert("Login successful!");
        window.location.href = "registration.html";
    } else {
        alert("Invalid username or password!");
    }
}
