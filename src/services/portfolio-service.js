import donnees from '../donnees/data.json'
const TECHNIQUE = "Technique"
const TRANSVERSE = "Transverse"

/**
 * Service permettant la récupération des données du portfolio
 */
export default class Service {

    static instance = null;

    /**
     * Obtenir une instance du service
     */
    static obtenirInstance() {
        if (this.instance == null) this.instance = new Service()
        return this.instance
    }

    /**
     * Obtenir une réalisation par son nom
     * @param {String} nomRealisation le nom d'une réalisation
     */
    obtenirRealisationParNom(nomRealisation) { 
        return donnees.realisations.find(realisation => realisation.nom === nomRealisation) 
    }
    
    /**
     * Obtenir une compétence par son nom
     * @param {String} nomCompetence le nom d'une compétence
     */
    obtenirCompetenceParNom(nomCompetence) { 
        return donnees.competences.find(competence => competence.nom === nomCompetence) 
    }
    
    /**
     * Obtenir les réalisations
     */
    obtenirRealisations() { 
        return donnees.realisations 
    }
    
    /**
     * Obtenir les compétences techniques
     */
    obtenirCompetencesTechniques() { 
        return donnees.competences.filter(competence => competence.type === TECHNIQUE) 
    }
    
    /**
     * Obtenir les compétences transverses
     */
    obtenirCompetencesTransverses() { 
        return donnees.competences.filter(competence => competence.type === TRANSVERSE) 
    }

}