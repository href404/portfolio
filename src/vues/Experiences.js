import React from 'react'
import { Link } from 'react-router-dom'

export default function Experiences() {
    return (
        <div className="container">
            <h2>Expériences <span role="img" aria-label="experiences">🔥</span></h2>
            <hr className="my-4" />
            <div className="card-deck">
                <div className="card">
                    <div className="card-header"><a href="http://www.infomil.com/">INFOMIL <span role="img" aria-label="infomil">🏢</span></a></div>
                    <div className="card-body">
                        <p className="card-text">
                            SS2I Toulousaine, j’ai intégré le pôle étude et développement durant un stage de 6
                        mois.</p>
                        <p className="card-text">
                            J’ai travaillé sur plusieurs projets de développement en <Link
                                to="/competences/techniques/csharp">C#</Link> et <Link
                                    to="/competences/techniques/android">Android</Link>, ce qui m’a permis de
                        développer mes compétences en ingénierie du logiciel.</p>
                    </div>
                    <div className="card-footer">
                        <small className="text-muted">2019 – Stage de 6 mois</small>
                    </div>
                </div>
                <div className="card">
                    <div className="card-header"><a href="http://www.infomil.com/">INFOMIL <span role="img" aria-label="infomil">🏢</span></a></div>
                    <div className="card-body">
                        <p className="card-text">
                            Je continue mon cursus dans la même entreprise ainsi que dans la même équipe de 5
                        personnes.</p>
                        <p className="card-text">
                            Sur la période de travail en cours, je profite des opportunités proposées pour peaufiner mes
                        compétences techniques et relationnelles.</p>
                        <p className="card-text">
                            Je participe au développement de l'équipe, et je monte en responsabilité sur les
                        projets qui me sont confiés.</p>
                    </div>
                    <div className="card-footer">
                        <small className="text-muted">2019 à aujourd'hui – Alternance de 2 ans</small>
                    </div>
                </div>
            </div>
        </div>
    );
}