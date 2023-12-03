

namespace Concurso
{
    public class BancoDados{
        List<Departamento> departamentos = new List<Departamento>();
        List<Cargo> cargos = new List<Cargo>();
        List<Candidato> candidatos = new List<Candidato>();
        List<Concurso> concursos = new List<Concurso>();
        List<Etapa> etapas = new List<Etapa>();
        List<Inscricao> inscricoes = new List<Inscricao>();
        List<Nota> notas = new List<Nota>();
        private object result;

        public BancoDados()
        {
            // proessor criamos alguns dados para permitir o uso rápido do sistema


            // adicionamos alguns candidatos 
            this.candidatos.Add(new Candidato("1", "Garu Souza","123456"));
            this.candidatos.Add(new Candidato("2", "Darwin Rookes","234567"));
            this.candidatos.Add(new Candidato("3", "Gamora Silva","567890"));

            // adicionamos alguns departamentos 
            this.departamentos.Add(new Departamento(1, "Departamento de TI"));
            this.departamentos.Add(new Departamento(2, "Departamento de TI"));
            this.departamentos.Add(new Departamento(3, "Departamento de TI"));


            // adicionamos alguns cargos 
            this.cargos.Add(new Cargo("1", "Analista de Java"));
            this.cargos.Add(new Cargo("2", "Analista de Python"));
            this.cargos.Add(new Cargo("3", "Analista de C#"));


            // adicionamos algumas etapas 
            this.etapas.Add(new Etapa("1", "Primeira etapa", "TI"));
            this.etapas.Add(new Etapa("2", "Segunda etapa", "Marketing"));
            this.etapas.Add(new Etapa("3", "Segunda etapa", "TI"));

            // adicionamos algumas notas
            this.notas.Add(new Nota(1, "Garu Souza", "1", "Primeira etapa"));
            this.notas.Add(new Nota(2, "Darwin Rookes","2", "Segunda etapa"));
            this.notas.Add(new Nota(3, "Gamora Silva", "3", "Segunda etapa"));

        }

        public int buscar(string onde, string oque)
        {
            int posicao = -1;

            

            if (onde == "candidato")
            {
                for (int x = 0; x < this.candidatos.Count; x++)
                {
                    if (candidatos[x].Codigo == oque)
                    {
                        posicao = x;
                        break;
                    }
                }
            }

            if (onde == "Departamento") posicao = this.departamentos.FindIndex(o => o.Equals(oque));

            if (onde == "Cargo") posicao = this.cargos.FindIndex(o => o.Codigo.Equals(oque));

            if (onde == "etapa") posicao = this.etapas.FindIndex(o => o.Codigo.Equals(oque));

            if (onde == "nota") posicao = this.notas.FindIndex(o => o.Codigo.Equals(oque));

            return posicao;
        }


        public object recuperar(string onde, int qual)
        {
            Object obj = null;
            if (onde == "candidato") obj = this.candidatos[qual];
            if (onde == "departamento") obj = this.departamentos[qual];
            if (onde == "cargo") obj = this.cargos[qual];
            if (onde == "etapa") obj = this.etapas[qual];
            if (onde == "nota") obj = this.notas[qual];

            return obj;
        }



        public void gravar(string onde, Object oque)
        {
            if (onde == "candidato") this.candidatos.Add((Candidato)oque);
            if (onde == "departamento") this.departamentos.Add((Departamento)oque);
            if (onde == "cargo") this.cargos.Add((Cargo)oque);
            if (onde == "etapa") this.etapas.Add((Etapa)oque);
            if (onde == "nota") this.notas.Add((Nota)oque);
        }


        public void alterar(string onde, Object oque, Object novo)
        {
            if (onde == "candidato")
            {
                int x = this.buscar("candidato", ((Candidato)oque).Codigo);
                this.candidatos[x] = (Candidato)novo;
            }

            if (onde == "departamento")
            {
                int x = this.buscar("departamento", ((Departamento)oque).Codigo);
                this.departamentos[x] = (Departamento)novo;
            }

            if (onde == "cargo")
            {
                int x = this.buscar("cargo", ((Cargo)oque).Codigo);
                this.cargos[x] = (Cargo)novo;
            }

            if (onde == "etapa")
            {
                int x = this.buscar("etapa", ((Etapa)oque).Codigo);
                this.etapas[x] = (Etapa)novo;
            }

            if (onde == "nota")
            {
                int x = this.buscar("nota", ((Nota)oque).Codigo);
                this.notas[x] = (Nota)novo;
            }
        }

    }
}
