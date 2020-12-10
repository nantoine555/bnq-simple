
namespace banque {

    public class Compte {

        private int numero;
        private double solde;
        private string referenceclient;

        public Compte() {}

        public Compte(int pNumero, double pSolde, string pReferenceclient) {
            this.numero = pNumero;
            this.solde = pSolde;
            this.referenceclient = pReferenceclient;
        }

        public int Numero {
            get {
                return numero;
            }
            set {
                numero = value;
            }
        }

        public double Solde {
            get {
                return solde;
            }
            set {
                solde = value;
            }
        }

        public string Referenceclient {
            get {
                return referenceclient;
            }
            set {
                referenceclient = value;
            }
        }
    }

}