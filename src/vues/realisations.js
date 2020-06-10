import React from 'react'
import Service from '../services/portfolio-service'
import { Link } from 'react-router-dom'

export default function Realisations() {

    const realisations = Service.obtenirRealisations()

    return (
        <div className="container">
            <h2>Réalisations <span role="img" aria-label="realisations">👌</span></h2>
            <hr className="my-4" />
            <div className="card-columns">{realisations.map((realisation, index) =>
                <div className="card" key={index}>
                    <div className="card-body">
                        <Link to={`/realisations/${realisation.nom}`}><h5 className="card-title">{realisation.titre}</h5></Link>
                        <p className="card-text">{realisation.description}</p>
                        <p className="card-text"><small className="text-muted">– {realisation.client} ・ {realisation.type}</small></p>
                    </div>
                </div>)}
            </div>
        </div>
    );
}