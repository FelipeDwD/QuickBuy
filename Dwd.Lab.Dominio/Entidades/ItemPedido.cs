﻿namespace Dwd.Lab.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }

        protected override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado a referência do produto.");

            if(Quantidade == 0)
                AdicionarCritica("Quantidade não foi informada.")
        }
    }
}
