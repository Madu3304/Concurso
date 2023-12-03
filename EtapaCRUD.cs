using Concurso;

public class EtapasCRUD
{
    private BancoDados bancoDados;
    private Tela tela;
    private int posicao;
    private string nomeEtapa;
    private string cargo;
    private string codigo;

    public string Codigo { get => codigo; private set => codigo = value; }
    public string NomeEtapa { get => nomeEtapa; private set => nomeEtapa = value; }
    public string Cargo { get => cargo; private set => cargo = value; }


    public EtapasCRUD(BancoDados bancoDados, Tela tela)
    {
        this.bancoDados = bancoDados;
        this.tela = tela;
    }

    public void executarCRUD()
    {
        String resp;
        this.posicao = -1;

        this.montarTela();
        this.posicao = bancoDados.buscar("Etapa", this.codigo);
    }

        public void montarTela()
        
        {
            tela.montarMoldura(10, 6, 70, 12, "Etapa");
            Console.SetCursorPosition(11, 8);
            Console.Write("Codigo        :");
            Console.SetCursorPosition(11, 9);
            Console.Write("Nome da Etapa :");
            Console.SetCursorPosition(11, 10);
            Console.Write("Cargo         :");
        }

    public void mostrarDados()
    {
        Console.SetCursorPosition(27, 9);
        Console.Write(this.nomeEtapa);
        Console.SetCursorPosition(27, 10);
        Console.Write(this.cargo);
    }


}