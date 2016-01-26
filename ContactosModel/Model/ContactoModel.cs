using System;

namespace ContactosModel.Model
{
    public class ContactoModel // no tenemos el entity de contacto pero creamos nosotros estras propertis
    {
        public int idOrigen { get; set; }
        public int idDestino { get; set; }
        public String nombreCompleto { get; set; }// para que me de el nombre completo del usuario 
    }
}