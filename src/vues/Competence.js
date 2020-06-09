import React from 'react'
import Service from '../services/portfolio-service'
import { Link } from 'react-router-dom'

export default function Competence({ match }) {

    const nom = match.params.nom
    const competence = Service.obtenirCompetenceParNom(nom)

    return (
        <div className="container">
            <h2>{competence.titre}</h2>
            <span className="badge badge-primary">{competence.type}</span>
            <small className="text-muted"> ・ {competence.temps_lecture} minutes de lecture</small>
            <hr className="my-4" />
            <p>{competence.contenu}</p>
            <hr className="my-4" />
            <ul className="list-inline">
                {competence.realisations.map((realisation, index) =>
                    <li className="list-inline-item" key={index}><Link to={`/realisations/${realisation}`} className="badge badge-dark">{realisation}</Link></li>
                )}
            </ul>
        </div >
    );

}