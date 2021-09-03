function sendMail(e) {
    e.preventDefault();
    try {
        const subject = document.getElementById("subject").value
        const message = document.getElementById("message").value
        window.location.href = `mailto:pierrejulienpro@outlook.fr?subject=${subject}&body=${message}`
    } catch (e) {
        throw new Error(e.message);
    }
    return false;
}