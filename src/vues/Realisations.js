import React from 'react'
import { Link } from 'react-router-dom'

export default function Realisations() {
    return (
        <div className="container">
            <h2>Réalisations <span role="img" aria-label="realisations">👌</span></h2>
            <hr className="my-4" />

            <div className="row">
                <div className="col-md-12">
                    <h5><a href="http://www.infomil.com/">INFOMIL <span role="img" aria-label="infomil">📁</span></a></h5>
                    <ul>
                        <li><Link to={"/realisations/referencement_terminaux"}>Référencement pour les terminaux</Link> <span role="img" aria-label="referencement">🖥️</span></li>
                        <li><Link to={"/realisations/gestion_parc_terminaux"}>Gestion de parc pour les terminaux</Link> <span role="img" aria-label="gestion-parc">🌐</span></li>
                        <li><Link to={"/realisations/surveillance_terminaux"}>Application mobile de surveillance des terminaux</Link> <span role="img" aria-label="surveillance">📱</span></li>
                        <li><Link to={"/realisations/migration_sql"}>Migration SQL Server en PostgreSQL</Link> <span role="img" aria-label="migration-sql">🖥️</span></li>
                        <li><Link to={"/realisations/recuperation_log_terminaux"}>Récupération des logs des terminaux</Link> <span role="img" aria-label="recuperation-log">🖥️</span></li>
                    </ul>
                </div>
            </div>

            <div className="row">
                <div className="col-md-12">
                    <h5><a href="https://www.intechinfo.fr/">IN'TECH <span role="img" aria-label="intech">📁</span></a></h5>
                    <ul>
                        <li><Link to={"/realisations/chambre_agriculture"}>Application mobile pour la Chambre de l'Agriculture</Link> <span role="img" aria-label="chambre-agriculture">📱</span></li>
                        <li><Link to={"/realisations/wawee"}>Application mobile pour Wawee</Link> <span role="img" aria-label="wawee">📱</span></li>
                        <li><Link to={"/realisations/clinique_st_hilaire"}>Résérvation pour les médecins de la Clinique Esquirol Saint Hilaire</Link> <span role="img" aria-label="clinique-st-hilaire">🌐</span></li>
                        <li><Link to={"/realisations/upsa"}>Gestionnaire de fichier pour UPSA</Link> <span role="img" aria-label="upsa">🌐</span></li>
                        <li><Link to={"/realisations/still_english"}>Jeu Still English</Link> <span role="img" aria-label="still-english">🌐</span></li>
                        <li><Link to={"/realisations/intech"}>Bureau des étudiants d'IN'TECH</Link> <span role="img" aria-label="intech">🌐</span></li>
                    </ul>
                </div>
            </div>
        </div>
    );
}