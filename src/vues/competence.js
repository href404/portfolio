import React from 'react'
import Service from '../services/portfolio-service'
import { Link } from 'react-router-dom'

export default function Competence({ match }) {

    const competence = Service.obtenirCompetenceParNom(match.params.nom)
    const nbreMots = competence.contenu.split(' ').length
    const tempsLecture = (nbreMots / 200).toFixed()

    return (
        <div className="container">
            <h2>{competence.titre}</h2>
            <span className="badge badge-primary">{competence.type}</span>
            <small className="text-muted"> ・ {tempsLecture} minutes de lecture</small>
            <hr className="my-4" />
            <div dangerouslySetInnerHTML={{ __html: competence.contenu }} />
            <hr className="my-4" />
            <ul className="list-inline">{competence.realisations.map((realisation, index) =>
                <li className="list-inline-item" key={index}>
                    <Link to={`/realisations/${realisation}`} className="badge badge-dark">
                        {Service.obtenirRealisationParNom(realisation).titre}
                    </Link>
                </li>)}
            </ul>
        </div >
    );
    
}