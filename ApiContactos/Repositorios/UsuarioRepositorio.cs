using System;
using System.Data.Entity;
using System.Linq;
using ApiContactos.Adapters;
using ApiContactos.Models;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;

namespace ApiContactos.Repositorios
{
    public class UsuarioRepositorio:BaseRepositorioEntity<Usuario,UsuarioModel,UsuarioAdapter>
    {
        public UsuarioRepositorio(DbContext context) : base(context)
        {
        }

        public UsuarioModel Validar(String login, String password)
        {
            var data = Get(o => o.login == login && o.password == password);

            if (data.Any())
                return data.First();
            return null;
        }

        public override UsuarioModel Add(UsuarioModel model)
        {
            if (IsUnico(model.login))
                return base.Add(model);
            return null;
        }

        public bool IsUnico(String login)//comprobar si el login existe o no
        {
            var data = Get(o => o.login == login);

            return !data.Any();
        }
    }
}