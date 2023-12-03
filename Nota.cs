
namespace Concurso
{
    public class Nota
    {
        private int valorNota;
        private String nomeCandidato;
        public string codigo;
        private string etapa;


        public string Codigo { get => codigo; private set => codigo = value; }
        public string NomeCandidato { get => nomeCandidato; private set => nomeCandidato = value; }
        public string Etapa { get => etapa; private set => etapa = value; }
        public int ValorNota { get => valorNota; private set => valorNota = value; }



        // método construtor
        public Nota(int Nota, string nomeCandidato, string codigo, string etapa, int nota = 0)
        {
            this.nomeCandidato = nomeCandidato;
            this.codigo = codigo;
            this.etapa = etapa;
            this.valorNota = nota;
        }
    }
}
