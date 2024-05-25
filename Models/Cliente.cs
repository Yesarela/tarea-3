namespace ClientesApp.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Dirección { get; set; }
        public string Compañía { get; set; }
        public string Nota { get; set; }
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;
    }
}