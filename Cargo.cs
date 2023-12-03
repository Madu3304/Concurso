namespace Concurso
{
    public class Cargo
    {
        // propriedades
        private string codigo;
        private string nomeCargo;
        private string departamento;

        public string NomeCargo { get => nomeCargo; private set => nomeCargo = value; }
        public string Codigo { get => codigo; private set => codigo = value; }
        public string Departamento { get => departamento; private set => departamento = value; }


        // método construtor
        public Cargo(string codigo, string nomeCargo)
        {
            this.codigo = codigo;
            this.nomeCargo = nomeCargo;
            this.departamento = departamento;
                                                                                                                                            }
    }
}