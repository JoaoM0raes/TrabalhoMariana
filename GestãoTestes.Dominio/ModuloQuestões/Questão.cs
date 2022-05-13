using GestãoTestes.Dominio.ModuloMatéria;
using GestaoTestes.Dominio.ModuloQuestões;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTestes.Dominio.ModuloQuestões
{
    public class Questão : EntidadeBase<Questão>
    {
        public string Enunciado { get; set; }
        public List<Respostas> Respostas { get; set; }
        public Materia Materias { get; set; }
        public int quantidadeAltermativas { get; set; }
        public override void Atualizar(Questão registro)
        {
            this.Respostas = registro.Respostas;
            this.Enunciado = registro.Enunciado;
            this.Materias = registro.Materias;  
        }
        
    }
}
