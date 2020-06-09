import React from 'react'

export default function Realisation({ match }) {
    return (
        <div className="container">
            <h2>{ match.params.nom }</h2>
            <hr className="my-4" />
        </div>
    );
}