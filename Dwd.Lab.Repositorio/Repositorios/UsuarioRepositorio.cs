﻿using System.Collections.Generic;
using System.Linq;
using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }

        public Usuario GetByCredenciais(string email, string senha)
        {
            return LabDataContext
                .Usuario
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public bool VerificarEmail(string email)
        {
            var existe = LabDataContext.Usuario.FirstOrDefault(u => u.Email == email);

            if (existe != null)
                return true;

            return false;
        }
    }
}
