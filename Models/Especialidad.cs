using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{ 
    public class Especialidad
    {
        
     
        // [KEY] le espcificamos a entity freamwork que idEspecialidad es la key en la base de datos
        [Key]
        public int IdEspecialidad { get; set; }
        
        public string Descripcion { get; set; }
        
    }
}
