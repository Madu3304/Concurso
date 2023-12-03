namespace Concurso


{
    public class Inscricao
    {
        // propriedades
        private string codigo;
        private string nomeCandidato;
        private string cpf;
        private string cargo;

        public string Codigo { get => codigo; private set => codigo = value; }
        public string Nome { get => nomeCandidato; private set => nomeCandidato = value; }
        public string Cpf { get => cpf; private set => cpf = value; }
        public string Cargo { get => cargo; private set => cargo = value; }

        // método construtor
        public Inscricao(string cod, string cargo, string nom, string doc)
        {
            this.codigo = cod;
            this.cpf = doc;
            this.nomeCandidato = nom;
            this.cargo = cargo;
        }

    }
}
