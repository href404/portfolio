import React from 'react'
import Service from '../services/portfolio-service'
import { Link } from 'react-router-dom'

export default function Competences() {

    const service = Service.obtenirInstance()
    const competencesTechniques = service.obtenirCompetencesTechniques()
    const competencesTransverses = service.obtenirCompetencesTransverses()

    return (
        <div className="container">
            <h2>Compétences <span role="img" aria-label="competences">🏔️</span></h2>
            <hr className="my-4" />
            <div className="row">
                <div className="col-md-6">
                    <h5>Techniques <span role="img" aria-label="competences-techniques">📁</span></h5>
                    <ul>{competencesTechniques.map((competence, index) =>
                        <li key={index}>
                            <Link to={`/competences/${competence.nom}`}>{competence.titre}</Link>
                        </li>)}
                    </ul>
                </div>
                <div className="col-md-6">
                    <h5>Transverses <span role="img" aria-label="competences-transverses">📁</span></h5>
                    <ul>{competencesTransverses.map((competence, index) =>
                        <li key={index}>
                            <Link to={`/competences/${competence.nom}`}>{competence.titre}</Link>
                        </li>)}
                    </ul>
                </div>
            </div>
        </div>
    );
}