using System.Diagnostics;
using ApiContactos.Models;
using ContactosModel.Model;
using RepositorioAdapter.Adapter;

namespace ApiContactos.Adapters
{
    public class MensajeAdapter:BaseAdapter<Mensaje,MensajeModel>
    {
        public override Mensaje FromViewModel(MensajeModel model)
        {
            return new Mensaje()
            {
                id = model.id,
                IdDestino = model.IdDestino,
                idOrigen = model.idOrigen,
                asunto = model.asunto,
                contenido = model.contenido,
                leido = model.leido,
                fecha = model.fecha
            };
        }

        public override MensajeModel FroModel(Mensaje model)
        {
            return new MensajeModel()
            {
                id = model.id,
                IdDestino = model.IdDestino,
                idOrigen = model.idOrigen,
                asunto =model.asunto,
                contenido = model.contenido,
                leido =  model.leido,
                fecha = model.fecha

            };
        }
    }
}