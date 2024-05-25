using System;
using System.ComponentModel.DataAnnotations;

namespace ClientesApp.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }
        
        [EmailAddress]
        [StringLength(100)]
        public string Correo { get; set; }
        
        [StringLength(200)]
        public string Dirección { get; set; }
        
        [StringLength(100)]
        public string Compañía { get; set; }
        
        public string Nota { get; set; }
        
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;
    }
}