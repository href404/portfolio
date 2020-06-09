import React from 'react'

export default function Competence({ match }) {

    const type = match.params.type
    const nom = match.params.nom

    return (
        <div className="container">
            <h2>{type} - {nom}</h2>
            <hr className="my-4" />
        </div>
    );
}