import React from 'react'

export default function Accueil() {
    return (
        <div className="container text-center">
            <h1>Pierre Julien</h1>
            <p>Ingénieur logiciel <span role="img" aria-label="informaticien">👨‍💻</span></p>
            <figure className="figure">
                <img src="/pierre.png" height="250" width="250" className="rounded" alt="Pierre Julien" />
            </figure>
            <p>Etudiant en 4ème année d'ingénierie du logiciel à <a href="https://www.intechinfo.fr/" target="_blank" rel="noopener noreferrer">IN'TECH Sud</a> et alternant chez <a href="http://www.infomil.com/" target="_blank" rel="noopener noreferrer">INFOMIL</a>.</p>

            <hr className="my-4" />
            <p><i>Passionné par les nouvelles technologies depuis mon plus jeune âge, j’ai décidé de poursuivre cette voie en pratiquant l’informatique dans ma vie professionnelle.</i></p>
            <p><i>Titulaire d'un baccalauréat professionnel, j'ai commencé mes études supérieures à IN'TECH en 2016. Une école d'informatique en 5 ans qui délivre un diplôme d'Expert en Ingénierie du Logiciel (RNCP niveau 1).</i></p>
            <p><i>Je suis actuellement en poste chez INFOMIL depuis 1 an, en tant qu'Ingénieur logiciel.</i></p>

            <hr className="my-4" />

            <a href="https://www.linkedin.com/in/pierre-julien/" target="_blank" rel="noopener noreferrer">
                <button type="button" className="btn btn-outline-primary btn-lg">Linkedin</button>
            </a>

        </div>
    );
}