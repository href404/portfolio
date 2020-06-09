import donnees from '../donnees/data.json'

export default class Service {

    static obtenirRealisationParNom(nomRealisation) {
        return donnees.realisations.find(realisation => realisation.nom === nomRealisation)
    }

    static obtenirCompetenceParNom(nomCompetence) {
        return donnees.competences.find(competence => competence.nom === nomCompetence)
    }

    static obtenirRealisations() {
        return donnees.realisations
    }

    static obtenirCompetences() {
        return donnees.competences
    }

}