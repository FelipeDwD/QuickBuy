﻿using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        /// <summary>
        ///  Endereço poder ter nenhum ou vários pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }

    }
}
