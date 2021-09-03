function sendMail(e) {
    e.preventDefault();
    try {
        alert("Votre email a été envoyé !")
    } catch (e) {
        throw new Error(e.message);
    }
    return false;
}