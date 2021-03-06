﻿using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Usuario 
    {
        public int Id { get; set; }      
             
        public string Email { get; set; }
        public string Senha { get; set; }
        
        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }     
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; }




    }
}
