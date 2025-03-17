function login() {
    alert("Login button clicked!");
}

function register() {
    alert("Register button clicked!");
}

function resetPassword() {
    alert("Reset Password button clicked!");
}

function checkEmail() {
    const email = document.getElementById("email").value;

    if (!email) {
        alert("Please enter your email.");
        return;
    }

    // Simulate checking email in database (AJAX request to backend)
    fetch("http://localhost:5000/check-email", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ email }),
    })
    .then(response => response.json())
    .then(data => {
        if (data.exists) {
            alert("OTP sent to your email!");
            document.getElementById("emailStep").style.display = "none";
            document.getElementById("otpStep").style.display = "block";
        } else {
            alert("Email not found!");
        }
    })
    .catch(error => console.error("Error:", error));
}

function verifyOtp() {
    const otp = document.getElementById("otp").value;

    if (!otp) {
        alert("Please enter the OTP.");
        return;
    }

    // Simulate verifying OTP (AJAX request)
    fetch("http://localhost:5000/verify-otp", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ otp }),
    })
    .then(response => response.json())
    .then(data => {
        if (data.verified) {
            alert("OTP verified! Enter a new password.");
            document.getElementById("otpStep").style.display = "none";
            document.getElementById("resetStep").style.display = "block";
        } else {
            alert("Invalid OTP!");
        }
    })
    .catch(error => console.error("Error:", error));
}

function resetPassword() {
    const newPassword = document.getElementById("newPassword").value;
    const confirmPassword = document.getElementById("confirmPassword").value;

    if (!newPassword || !confirmPassword) {
        alert("Please enter a new password.");
        return;
    }

    if (newPassword !== confirmPassword) {
        alert("Passwords do not match!");
        return;
    }

    // Simulate updating password in the database (AJAX request)
    fetch("http://localhost:5000/reset-password", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ newPassword }),
    })
    .then(response => response.json())
    .then(data => {
        if (data.success) {
            alert("Password reset successful! Redirecting to login...");
            window.location.href = "AuthLogin.html";
        } else {
            alert("Error resetting password!");
        }
    })
    .catch(error => console.error("Error:", error));
}








//const express = require("express");
// const cors = require("cors");
// const bodyParser = require("body-parser");

// const app = express();
// app.use(cors());
// app.use(bodyParser.json());

// let fakeDatabase = { "test@example.com": { otp: "123456", password: "oldPass" } };

// app.post("/check-email", (req, res) => {
//     const { email } = req.body;
//     if (fakeDatabase[email]) {
//         res.json({ exists: true });
//     } else {
//         res.json({ exists: false });
//     }
// });

// app.post("/verify-otp", (req, res) => {
//     const { otp } = req.body;
//     if (otp === "123456") {
//         res.json({ verified: true });
//     } else {
//         res.json({ verified: false });
//     }
// });

// app.post("/reset-password", (req, res) => {
//     const { newPassword } = req.body;
//     // Here, update password logic should be implemented in a real database
//     res.json({ success: true });
// });

// app.listen(5000, () => console.log("Server running on port 5000"));
