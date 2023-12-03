using Concurso;

public class CargosCRUD
{
    private BancoDados bancoDados;
    private Tela tela;
    private int posicao;
    private string nome;
    private string codigo;

    public CargosCRUD(BancoDados bancoDados, Tela tela)
    {
        this.bancoDados = bancoDados;
        this.tela = tela;
    }
    public void executarCRUD()
    {
        String resp;
        this.posicao = -1;

        this.montarTela();
        this.posicao = bancoDados.buscar("Cargo", this.codigo);
    }

    public void montarTela()
    {
        tela.montarMoldura(10, 6, 70, 12, "Cargo");
        Console.SetCursorPosition(11, 8);
        Console.Write("Codigo        :");
        Console.SetCursorPosition(11, 9);
        Console.Write("Nome          :");
        Console.SetCursorPosition(11, 10);

    }


    public void mostrarDados()
    {
        Console.SetCursorPosition(27, 9);
        Console.Write(this.nome);
        Console.SetCursorPosition(27, 10);
        Console.Write(this.codigo);
    }
}