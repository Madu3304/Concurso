using Concurso;

public class ConcursoCRUD
{
    private BancoDados bancoDados;
    private Tela tela;
    private int posicao;
    private string codigo;
    private string nomeCargo;
    private string data;

    public void concursoCRUD(BancoDados bancoDados, Tela tela)
    {
        this.bancoDados = bancoDados;
        this.tela = tela;
    }

    public void executarCRUD()
    {
        String resp;
        this.posicao = -1;

        this.montarTela();
        this.posicao = bancoDados.buscar("Concurso", this.codigo);
    }

    public void montarTela()
    {
        tela.montarMoldura(10, 6, 70, 12, "Concurso");
        Console.SetCursorPosition(11, 8);
        Console.Write("Codigo        :");
        Console.SetCursorPosition(11, 9);
        Console.Write("Nome do Cargo :");
        Console.SetCursorPosition(11, 10);
        Console.Write("Data  : 12-12-2023");
    }

}