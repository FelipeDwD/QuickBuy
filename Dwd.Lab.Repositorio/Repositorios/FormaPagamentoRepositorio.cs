﻿using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.ObjetoDeValor;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class FormaPagamentoRepositorio : BaseRepositorio<FormaPagamento>, IFormaPagamentoRepositorio
    {
        public FormaPagamentoRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }
    }
}
