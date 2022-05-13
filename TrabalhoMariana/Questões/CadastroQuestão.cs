using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Dominio.ModuloQuestões;
using GestaoTestes.Dominio.ModuloQuestões;

namespace GestãoTeste.Questões
{
    public partial class CadastroQuestão : Form
    {
        private Questão questao;
        private Respostas resposta;
        private List<Respostas> respostas = new List<Respostas>();
        private Materia materias;
        public CadastroQuestão(List<Materia> materias, List<Disciplinas> disciplinas)
        {
            InitializeComponent();
            atualizarComponentes(disciplinas, materias);
        }
        public void atualizarComponentes(List<Disciplinas> disciplinas, List<Materia> materias)
        {
            comboDisciplina.Items.Clear();
            foreach (var item in disciplinas)
            {
                comboDisciplina.Items.Add(item);
            }

        }

        public Func<Questão, ValidationResult> GravarRegistro { get; set; }
        public Questão Questao
        {
            get { return questao; }
            set
            {
                this.questao = value;

            }
        }


        private void btnGravar_Click_1(object sender, EventArgs e)
        {

            questao.Enunciado = textEnunciado.Text;
            questao.Materias = (Materia)comboMateria.SelectedItem;
            questao.Respostas = respostas;
            questao.quantidadeAltermativas = respostas.Count;
            var resultadoValidacao = GravarRegistro(Questao);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                DialogResult = DialogResult.None;
            }
        }


        private void comboDisciplina_SelectedValueChanged(object sender, EventArgs e)
        {

            Disciplinas disciplinaSelecionada = (Disciplinas)comboDisciplina.SelectedItem;

            foreach (var item in disciplinaSelecionada.Materias)
            {
                 comboMateria.Items.Add(item);
            }
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            
            this.resposta = new Respostas();
            resposta.Resposta = textAlternativa.Text;
            respostas.Add(resposta);
            listAlternativas.Items.Clear();
            foreach (var item in respostas)
            {
                listAlternativas.Items.Add(item);
            }
        }

       
    }
}
