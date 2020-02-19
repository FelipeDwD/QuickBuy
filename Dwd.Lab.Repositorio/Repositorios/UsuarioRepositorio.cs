using System.Collections.Generic;
using System.Linq;
using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(LabDataContext labDataContext) : base(labDataContext)
        {
        }

        public bool Ativo(string cpf)
        {
            var usuario = LabDataContext
                .Usuario
                .FirstOrDefault(u => u.Cpf == cpf && u.Ativo == true);

            if (usuario != null)
                return true;

            return false;
        }      

        public Usuario GetByCredenciais(string email, string senha)
        {
            return LabDataContext
                .Usuario
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public bool VerificarCpf(string cpf)
        {
            var existe = LabDataContext.Usuario.FirstOrDefault(u => u.Cpf == cpf);

            if (existe != null)
                return true;

            return false;
        }

        public bool VerificarCpf(int id, string cpf)
        {
            var cpfIsOfUser = LabDataContext
                              .Usuario
                              .AsNoTracking()
                              .FirstOrDefault(u => u.Id == id && u.Cpf == cpf);

            if (cpfIsOfUser != null)
                return true;

            return false;
        }

        public bool VerificarEmail(string email)
        {
            var existe = LabDataContext.Usuario.FirstOrDefault(u => u.Email == email);           

            if (existe != null)
                return true;

            return false;
        }
        
        public bool VerificarEmail(int id, string email)
        {
            var emailIsOfUser = LabDataContext
                         .Usuario
                         .AsNoTracking()
                         .FirstOrDefault(u => u.Id == id && u.Email == email);

            if (emailIsOfUser != null)
                return true;

            return false;
           
        }
    }
}
