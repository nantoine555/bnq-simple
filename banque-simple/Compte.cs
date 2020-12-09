namespace banque
{
    class Compte {

        private int pNumero;
        private double pSolde;
        private string pReferenceClient;

        public Compte() {

        }

        public Compte (int numero, double solde, string referenceClient) {
            this.pNumero = numero;
            this.pSolde = solde;
            this.pReferenceClient = referenceClient;
        }

        public void setNumero(int numero)
        {
            this.pNumero = numero;
        }

        public void setSolde(double solde)
        {
            this.pSolde = solde;
        }

        public void setReferenceClient(string referenceClient)
        {
            this.pReferenceClient = referenceClient;
        }

        public int getNumero()
        {
            return this.pNumero;
        }

        public double getSolde()
        {
            return this.pSolde;
        }

        public string getReferenceClient()
        {
            return this.pReferenceClient;
        }



    }
}