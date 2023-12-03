using Concurso;

Tela tela = new Tela();
BancoDados bancoDados = new BancoDados();


CandidatoCRUD candidato = new CandidatoCRUD(bancoDados, tela);
DepartamentoCRUD departamento = new DepartamentoCRUD(bancoDados, tela);

/*CargosCRUD cargo = new CargosCRUD(bancoDados, tela);
ConcursoCRUD concurso = new ConcursoCRUD(bancoDados, tela);
EtapasCRUD etapa = new EtapasCRUD(bancoDados, tela);
InscricaoCRUD inscricao = new InscricaoCRUD(bancoDados, tela);
NotaCRUD nota = new NotaCRUD(bancoDados, tela);
*/

List<string> menu = new List<string>();
menu.Add("1 - DEPARTAMENTOS");
menu.Add("2 - CARGOS       ");
menu.Add("3 - CANDIDATURA  ");
menu.Add("4 - ETAPAS       ");
menu.Add("5 - CONCURSOS    ");
menu.Add("6 - INSCRICAO    ");
menu.Add("7 - NOTAS        ");
menu.Add("0 - VOLTAR       ");

string op;

while (true)
{
    tela.montarTelaSistema("Sistemas de Anotações");
    op = tela.mostrarMenu(menu, 5, 5);

    if (op == "0") break;
    if (op == "1") departamento.executarCRUD();
    if (op == "2") cargo.executarCRUD();
    if (op == "3") candidato.executarCRUD();
    if (op == "4") etapa.executarCRUD();
    if (op == "5") concurso.executarCRUD();
    if (op == "6") inscricao.executarCRUD();
    if (op == "7") nota.executarCRUD();
    if (op == "8") anotacaoCRUD();
}