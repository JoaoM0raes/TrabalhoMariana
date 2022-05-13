﻿using FluentValidation.Results;
using GestãoTestes.Dominio;
using System.Collections.Generic;

namespace GestãoTeste.Disciplina
{
    public interface IRepositorio<T> where T : EntidadeBase<T>
    {
        ValidationResult Inserir(T novoRegistro);

        ValidationResult Editar(T registro);

        ValidationResult Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorNumero(int numero);
    }
}