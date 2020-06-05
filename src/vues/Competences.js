import React from 'react'
import { Link } from 'react-router-dom'

export default function Competences() {
    return (
        <div className="container">
            <h2>Compétences <span role="img" aria-label="competences">🏔️</span></h2>
            <hr className="my-4" />
            <div className="row">
                <div className="col-md-6">
                    <h5><Link to={"/competences/techniques"}>Techniques <span role="img" aria-label="competences-techniques">📁</span></Link></h5>
                    <ul>
                        <li>
                            <Link to={"/competences/techniques/csharp"}>C#</Link>
                            <ul>
                                <li><Link to={"/competences/techniques/entityframework"}>Entity Framework</Link></li>
                                <li><Link to={"/competences/techniques/linq"}>Linq</Link></li>
                            </ul>
                        </li>
                        <li>
                            <Link to={"/competences/techniques/android"}>Android</Link>
                            <ul>
                                <li><Link to={"/competences/techniques/kotlin"}>Kotlin</Link></li>
                                <li><Link to={"/competences/techniques/java"}>Java</Link></li>
                            </ul>
                        </li>
                        <li><Link to={"/competences/techniques/xamarin"}>Xamarin</Link></li>
                        <li>
                            <Link to={"/competences/techniques/javascript"}>JavaScript</Link>
                            <ul>
                                <li><Link to={"/competences/techniques/typescript"}>TypeScript</Link></li>
                            </ul>
                        </li>
                        <li><Link to={"/competences/techniques/docker"}>Docker <span role="img" aria-label="docker">🐋</span></Link></li>
                        <li><Link to={"/competences/techniques/bash"}>Bash</Link></li>
                        <li><Link to={"/competences/techniques/php"}>PHP</Link></li>
                        <li>
                            <Link to={"/competences/techniques/sql"}>SQL <span role="img" aria-label="sql">📊</span></Link>
                            <ul>
                                <li><Link to={"/competences/techniques/slqserver"}>SQL Server</Link></li>
                                <li><Link to={"/competences/techniques/mysql"}>MySQL</Link></li>
                                <li><Link to={"/competences/techniques/postgresql"}>PostgreSQL</Link></li>
                            </ul>
                        </li>
                        <li>
                            <Link to={"/competences/techniques/versionning"}>Versionning <span role="img" aria-label="versionning">🗄️</span></Link>
                            <ul>
                                <li><Link to={"/competences/techniques/git"}>Git</Link></li>
                                <li><Link to={"/competences/techniques/perforce"}>Perforce</Link></li>
                            </ul>
                        </li>
                        <li>
                            <Link to={"./competences/techniques/reseau"}>Réseau <span role="img" aria-label="reseau">☁️</span></Link>
                            <ul>
                                <li><Link to={"/competences/techniques/iis"}>IIS</Link></li>
                                <li><Link to={"/competences/techniques/apache"}>Apache</Link></li>
                                <li><Link to={"/competences/techniques/nginx"}>Nginx</Link></li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <div className="col-md-6">
                    <h5><Link to={"./competences/transverses"}>Transverses <span role="img" aria-label="competences-transverses">📁</span></Link></h5>
                    <ul>
                        <li><Link to={"./competences/transverses/communication"}>Communication</Link></li>
                        <li><Link to={"./competences/transverses/contact_client"}>Contact client</Link></li>
                        <li>
                            <Link to={"./competences/transverses/travail_equipe"}>Travail d'équipe <span role="img" aria-label="travail-equipe">👨‍👩‍👧‍👦</span></Link>
                            <ul>
                                <li><Link to={"./competences/transverses/agile_scrum"}>Agile Scrum</Link></li>
                                <li><Link to={"./competences/transverses/kanban"}>Kanban</Link></li>
                            </ul>
                        </li>
                        <li><Link to={"./competences/transverses/formation"}>Formation</Link></li>
                        <li><Link to={"./competences/transverses/montage_video"}>Montage vidéo</Link></li>
                        <li><Link to={"./competences/transverses/gestion_budget"}>Gestion de budget</Link></li>

                    </ul>
                </div>
            </div>
        </div>
    );
}