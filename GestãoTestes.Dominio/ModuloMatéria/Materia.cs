using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Dominio.ModuloQuestões;

namespace GestãoTestes.Dominio.ModuloMatéria
{
    public class Materia : EntidadeBase<Materia>
    {
        public List<Questão> questoes;
        public string Nome { get; set; }
        public Disciplinas Disciplina { get; set; }
        public int Serie { get; set; }

        public override void Atualizar(Materia registro)
        {
            this.Nome = registro.Nome;
            this.Disciplina=registro.Disciplina;
            this.Serie = registro.Serie;    
        }
    }
}
