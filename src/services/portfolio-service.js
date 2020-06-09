import donnees from '../donnees/data.json'

export default class Service {

    static obtenirRealisationParNom(nomRealisation) { return donnees.realisations.find(realisation => realisation.nom === nomRealisation) }
    static obtenirCompetenceParNom(nomCompetence) { return donnees.competences.find(competence => competence.nom === nomCompetence) }
    static obtenirRealisations() { return donnees.realisations }
    static obtenirCompetencesTechniques() { return donnees.competences.filter(competence => competence.type === "Technique") }
    static obtenirCompetencesTransverses() { return donnees.competences.filter(competence => competence.type === "Transverse") }
    static melangerTableau(tableau) {
        let counter = tableau.length;
        while (counter > 0) {
            let index = Math.floor(Math.random() * counter);
            counter--;
            let temp = tableau[counter];
            tableau[counter] = tableau[index];
            tableau[index] = temp;
        }
    
        return tableau;
    }
}