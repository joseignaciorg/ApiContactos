namespace ContactosModel.Model
{
    public class MensajeModel
    {
        public int id { get; set; }
        public int idOrigen { get; set; }
        public int IdDestino { get; set; }
        public string asunto { get; set; }
        public string contenido { get; set; }
        public bool leido { get; set; }
        public System.DateTime fecha { get; set; }
    }
}