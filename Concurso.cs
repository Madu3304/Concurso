namespace Concurso


{
    public class Concurso
    {
        // propriedades
        private string codigo;
        private string nomeCargo;
        private string data;

        public string Codigo { get => codigo; private set => codigo = value; }
        public string NomeCargo { get => nomeCargo; private set => nomeCargo = value; }
        
        // método construtor
        public Concurso(string cod, string nom, string dat)
        {
            this.codigo = cod;
            this.data = dat;
            this.nomeCargo = nom;
        }

    }
}
