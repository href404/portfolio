import React from 'react';
import Navbar from './Navbar';
import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Accueil from './vues/Accueil';
import Realisations from './vues/Realisations';
import Experiences from './vues/Experiences';
import Competences from './vues/Competences';
import Inconnu from './vues/Inconnu';

export default function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Navbar />
        <Switch>
          <Route path="/" exact component={Accueil} />
          <Route path="/competences" exact component={Competences} />
          <Route path="/competences/techniques" exact />
          <Route path="/competences/techniques/:nom" />
          <Route path="/competences/transverses" exact />
          <Route path="/competences/transverses/:nom" />
          <Route path="/realisations" exact component={Realisations} />
          <Route path="/realisations/:nom" />
          <Route path="/experiences" exact component={Experiences} />
          <Route component={Inconnu}/>
        </Switch>
      </div>
    </BrowserRouter>
  );
}