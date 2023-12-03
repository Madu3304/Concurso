namespace Concurso
{
    public class Etapa
    {
        // propriedades
        private string cargo;
        private string nomeEtapa;
        public string codigo { get; private set; }


        public string Codigo { get => codigo; private set => codigo = value; }
        public string NomeEtapa { get => nomeEtapa; private set => nomeEtapa = value; }
        public string Cargo { get => cargo; private set => cargo = value; }

        // método construtor
        public Etapa(string codigo, string nomeEtapa, string cargo)
        {
            this.cargo = cargo;
            this.nomeEtapa = nomeEtapa;
            this.codigo = codigo;
        }
    }
}

