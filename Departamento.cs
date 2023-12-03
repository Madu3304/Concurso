namespace Concurso
{
    public class Departamento
    {
        // propriedades
        private string codigo;
        private string nomeDepartamento;
        

        public string Codigo { get => codigo; set => codigo = value; }
        public string NomeDepartamento { get => nomeDepartamento; set => nomeDepartamento = value; }


        // método construtor
        public Departamento(int cdDepartamento, string nomeDepartamento)
        {
            this.codigo = codigo;
            this.nomeDepartamento= nomeDepartamento;
        }

    }
}