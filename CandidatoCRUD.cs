using Concurso;


public class CandidatoCRUD
{
    private BancoDados bancoDados;
    private Tela tela;
    private int posicao;
    private string codigo, nome, cpf;
    

    public CandidatoCRUD(BancoDados bancoDados, Tela tela)
    {
        this.bancoDados = bancoDados;
        this.tela = tela;
    }





    public void executarCRUD()
    {
        String resp;
        this.posicao = -1;

        this.montarTela();
        this.entrarCodigo();
        this.posicao = bancoDados.buscar("candidato", this.codigo);


        if (this.posicao == -1)
        {
            
            resp = tela.fazerPergunta(11, 11, "Candidato NÃO encontrado. Deseja se candidatar?  (S/N):");
            if (resp.ToUpper() == "S")
            {
                this.entrarDados();
                resp = tela.fazerPergunta(11, 11, "Confirma candidato (S/N):");
                if (resp.ToUpper() == "S")
                {
                    bancoDados.gravar("candidato", new Candidato(this.codigo, this.nome, this.cpf));
                }
            }
        }
       
    }

    public void montarTela()
    {
        tela.montarMoldura(10, 6, 70, 12, "Candidato");
        Console.SetCursorPosition(11, 8);
        Console.Write("Codigo        :");
        Console.SetCursorPosition(11, 9);
        Console.Write("Nome          :");
        Console.SetCursorPosition(11, 10);
        Console.Write("cpf :");
    }

    public void entrarCodigo()
    {
        Console.SetCursorPosition(27, 8);
        this.codigo = Console.ReadLine();
    }

    public void entrarDados()
    {
        Console.SetCursorPosition(27, 9);
        this.nome = Console.ReadLine();
        Console.SetCursorPosition(27, 10);
        this.cpf = Console.ReadLine();
    }

    public void mostrarDados()
    {
        Console.SetCursorPosition(27, 9);
        Console.Write(this.nome);
        Console.SetCursorPosition(27, 10);
        Console.Write(this.cpf);
    }
}
