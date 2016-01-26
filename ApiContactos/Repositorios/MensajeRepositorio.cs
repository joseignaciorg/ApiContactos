using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using ApiContactos.Adapters;
using ApiContactos.Models;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;

namespace ApiContactos.Repositorios
{
    public class MensajeRepositorio:BaseRepositorioEntity<Mensaje,MensajeModel,MensajeAdapter>
    {
        public MensajeRepositorio(DbContext context) : base(context)
        {

        }

        public ICollection<MensajeModel> GetByDestino(int idDestino)// aqui tengo todos los mensajes
        {
            var data = Get(o => o.IdDestino == idDestino).OrderByDescending(o=>o.fecha);
            return data.ToList();
        }

        public ICollection<MensajeModel> GetbyOrigen(int idOrigen)
        {
            var data = Get(o => o.idOrigen == idOrigen).OrderByDescending(o => o.fecha);
            return data.ToList();
        } 
    }
}