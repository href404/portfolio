import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Navbar from './vues/barre-navigation';
import Accueil from './vues/accueil';
import Realisations from './vues/Realisations';
import Experiences from './vues/experiences';
import Competences from './vues/competences';
import Inconnu from './vues/inconnu';
import Realisation from './vues/Realisation';
import Competence from './vues/competence';
import './index.css';

ReactDOM.render(
    <React.StrictMode>
        <BrowserRouter>
            <Navbar />
            <Switch>
                <Route path="/" exact component={Accueil} />
                <Route path="/competences" exact component={Competences} />
                <Route path="/competences/:nom" component={Competence} />
                <Route path="/realisations" exact component={Realisations} />
                <Route path="/realisations/:nom" component={Realisation} />
                <Route path="/experiences" exact component={Experiences} />
                <Route component={Inconnu} />
            </Switch>
        </BrowserRouter>
    </React.StrictMode>,
    document.getElementById('root')
);