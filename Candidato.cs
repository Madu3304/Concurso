namespace Concurso
{
    public class Candidato
    {
        // propriedades
        private string codigo;
        private string nome;
        private string cpf;

        public string Codigo{ get => codigo; private set => codigo = value; }
        public string Nome{ get => nome; private set => nome = value; }
        public string Cpf { get => cpf; private set => cpf = value; }

        // método construtor
        public Candidato(string cod, string nom, string doc)
        {
            this.codigo = cod;
            this.cpf = doc;
            this.nome = nom;
        }

         
    }

}
