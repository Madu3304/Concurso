    using Concurso;


public class InscricaoCRUD
{
    private BancoDados bancoDados;
    private Tela tela;
    private int posicao;
    private string nomeCandidato;
    private string cpf, codigo;
    private int cargo;

    public InscricaoCRUD(BancoDados bancoDados, Tela tela)
    {
        this.bancoDados = bancoDados;
        this.tela = tela;
    }

    public void executarCRUD()
    {
        String resp;
        this.posicao = -1;

        this.montarTela();
        this.posicao = bancoDados.buscar("Inscricao", this.codigo);

    }

    public void montarTela()
    {
        tela.montarMoldura(10, 6, 70, 12, "Candidato");
        Console.SetCursorPosition(11, 8);
        Console.Write("Codigo                :");
        Console.SetCursorPosition(11, 9);
        Console.Write("Nome do Candidato     :");
        Console.SetCursorPosition(11, 10);
        Console.Write("Cpf                   :");
        Console.SetCursorPosition(11, 11);
        Console.Write("Cargo de Interesse    :");
    }

    public void mostrarDados()
    {
        Console.SetCursorPosition(27, 9);
        Console.Write(this.nomeCandidato);
        Console.SetCursorPosition(27, 10);
        Console.Write(this.cargo);
        Console.SetCursorPosition(27, 11);
        Console.Write(this.cpf);
    }

}