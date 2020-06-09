import React from 'react'
import { Link } from 'react-router-dom'

export default function Competences() {
    return (
        <div className="container">
            <h2>Compétences <span role="img" aria-label="competences">🏔️</span></h2>
            <hr className="my-4" />
            <div className="row">
                <div className="col-md-6">
                    <h5>Techniques <span role="img" aria-label="competences-techniques">📁</span></h5>
                    <ul>
                        <li><Link to={"/competences/techniques/csharp"}>C#</Link></li>
                        <li><Link to={"/competences/techniques/android"}>Android</Link></li>
                        <li><Link to={"/competences/techniques/xamarin"}>Xamarin</Link></li>
                        <li><Link to={"/competences/techniques/javascript"}>JavaScript</Link></li>
                        <li><Link to={"/competences/techniques/docker"}>Docker <span role="img" aria-label="docker">🐋</span></Link></li>
                        <li><Link to={"/competences/techniques/bash"}>Bash</Link></li>
                        <li><Link to={"/competences/techniques/php"}>PHP</Link></li>
                        <li><Link to={"/competences/techniques/sql"}>SQL <span role="img" aria-label="sql">📊</span></Link></li>
                        <li><Link to={"/competences/techniques/versionning"}>Versionning <span role="img" aria-label="versionning">🗄️</span></Link></li>
                    </ul>
                </div>
                <div className="col-md-6">
                    <h5>Transverses <span role="img" aria-label="competences-transverses">📁</span></h5>
                    <ul>
                        <li><Link to={"./competences/transverses/communication"}>Communication</Link></li>
                        <li><Link to={"./competences/transverses/contact_client"}>Contact client</Link></li>
                        <li><Link to={"./competences/transverses/travail_equipe"}>Travail d'équipe <span role="img" aria-label="travail-equipe">👨‍👩‍👧‍👦</span></Link></li>
                        <li><Link to={"./competences/transverses/formation"}>Formation</Link></li>
                        <li><Link to={"./competences/transverses/montage_video"}>Montage vidéo</Link></li>
                        <li><Link to={"./competences/transverses/gestion_budget"}>Gestion de budget</Link></li>
                    </ul>
                </div>
            </div>
        </div>
    );
}