using FluentValidation;
using GestãoTeste.Disciplina;
using GestãoTestes.Dominio.ModuloDisciplina;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;

namespace TrabalhoMariana
{
    public class RepositorioDisciplinaEmArquivo:RepositorioEmArquivoBase<Disciplinas>, IRepositorioDisciplina
    {
        

        public RepositorioDisciplinaEmArquivo(DataContext dataContext) : base(dataContext)
        {
             
        }
        public override List<Disciplinas> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }
        public override AbstractValidator<Disciplinas> ObterValidador()
        {
            return new ValidadorDisciplina();
        }
    }
}