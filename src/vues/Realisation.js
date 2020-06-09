import React from 'react'
import Service from '../services/portfolio-service'
import { Link } from 'react-router-dom'

export default function Realisation({ match }) {

    const realisation = Service.obtenirRealisationParNom(match.params.nom)

    return (
        <div className="container">
            <h2>{realisation.titre}</h2>
            <span className="badge badge-primary">Réalisation</span>
            <small className="text-muted"> ・ {realisation.temps_lecture} minutes de lecture  ・ {realisation.type}</small>
            <hr className="my-4" />
            <div dangerouslySetInnerHTML={{__html: realisation.contenu }} />
            <hr className="my-4" />
            <ul className="list-inline">{realisation.competences.map((competence, index) =>
                <li className="list-inline-item" key={index}>
                    <Link to={`/competences/${competence}`} className="badge badge-dark">
                        {Service.obtenirCompetenceParNom(competence).titre}
                    </Link>
                </li>)}
            </ul>
        </div >
    );
}