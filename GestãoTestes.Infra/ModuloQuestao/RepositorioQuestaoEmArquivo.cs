using FluentValidation;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Dominio.ModuloQuestões;
using GestaoTestes.Dominio.ModuloQuestões;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;

namespace TrabalhoMariana
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questão>, IrepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(DataContext dataContext) : base(dataContext)
        {

        }

        public override List<Questão> ObterRegistros()
        {
            return dataContext.Questões;
        }

        public override AbstractValidator<Questão> ObterValidador()
        {
            return new ValidadorQuestao();
        }
    }
}