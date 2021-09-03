function sendMail(e) {
    e.preventDefault();
    try {
        const email = document.getElementById("email").value
        const subject = document.getElementById("subject").value
        const message = document.getElementById("message").value
        window.location.href = `mailto:${email}?subject=${subject}&body=${message}`
    } catch (e) {
        throw new Error(e.message);
    }
    return false;
}