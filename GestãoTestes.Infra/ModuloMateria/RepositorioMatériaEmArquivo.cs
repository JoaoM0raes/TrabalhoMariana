using FluentValidation;
using GestãoTeste.Disciplina;
using GestãoTestes.Dominio.ModuloMatéria;
using GestãoTestes.Infra.Compartilhado;
using System.Collections.Generic;

namespace TrabalhoMariana
{
    public class RepositorioMatériaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
     

        public RepositorioMatériaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            
        }

        public override List<Materia> ObterRegistros()
        {
            return dataContext.Matérias;
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }
    }
}