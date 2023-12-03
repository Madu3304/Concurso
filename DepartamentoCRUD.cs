using Concurso;


namespace Concurso
{
    public class DepartamentoCRUD
    {
        private BancoDados bancoDados;
        private Tela tela;
        private int posicao;
        private string cargo;
        private string codigo;
        private string nomeDepartamento;



        public DepartamentoCRUD(BancoDados b, Tela t)
        {
            this.bancoDados = b;
            this.tela = t;
        }


        public void executarCRUD()
        {
            String resp;
            this.posicao = -1;

            this.montarTela();
            this.posicao = bancoDados.buscar("Departamento", this.codigo);

        }

        public void montarTela()
        {
            tela.montarMoldura(10, 6, 70, 12, "Departamento");
            Console.SetCursorPosition(11, 8);
            Console.Write("Codigo        :");
            Console.SetCursorPosition(11, 9);
            Console.Write("Cargo          :");
           
        }

        public void mostrarDados()
        {
            Console.SetCursorPosition(27, 9);
            Console.Write(this.nomeDepartamento);
            Console.SetCursorPosition(27, 10);
            Console.Write(this.cargo);

        }
    }
}
