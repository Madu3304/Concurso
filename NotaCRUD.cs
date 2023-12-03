namespace Concurso
{
    public class NotaCRUD
    {
        private BancoDados bancoDados;
        private Tela tela;
        private int posicao;
        private string codigo, nomeCandidato, nota, etapa;

        public string Nota { get => nota; private set => nota = value; }
        public string NomeCandidato { get => nomeCandidato; private set => nomeCandidato = value; }
        public string Codigo { get => codigo; private set => codigo = value; }
        public string Etapa { get => etapa; private set => etapa = value; }



        public void InscricaoCRUD(BancoDados bancoDados, Tela tela)
        {
            this.bancoDados = bancoDados;
            this.tela = tela;
        }

        public void executarCRUD()

        {
            String resp;
            this.posicao = -1;

            this.montarTela();
            this.posicao = bancoDados.buscar("Nota", this.codigo);
        }




        public void montarTela()
        {
            tela.montarMoldura(10, 6, 70, 12, "Candidato");
            Console.SetCursorPosition(11, 8);
            Console.Write("Codigo        :");
            Console.SetCursorPosition(11, 9);
            Console.Write("Etapa         :");
            Console.SetCursorPosition(11, 10);
            Console.Write("Nota          :");
            Console.SetCursorPosition(11, 11);
            Console.Write("Etapa         :");
        }

        public void mostrarDados()
        {
            Console.SetCursorPosition(27, 9);
            Console.Write(this.nomeCandidato);
            Console.SetCursorPosition(27, 10);
            Console.Write(this.etapa);
            Console.SetCursorPosition(27, 11);
            Console.Write(this.nota);
        }


    }
}