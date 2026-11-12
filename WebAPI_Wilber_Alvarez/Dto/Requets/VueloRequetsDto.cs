using System.ComponentModel.DataAnnotations;

namespace WebAPI_Wilber_Alvarez.Dto.Requets
{
    public class VueloRequetsDto
    {
        [Required(ErrorMessage ="La Aerolinea es obligatoria")]
        public int Aerolinea { get; set; }


        [Required(ErrorMessage = "El nuemero de vuelo es obligatorio")]
        public string NumeroDeVuelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El aero puerto de origen es obligatorio")]
        public int AeroPuertoOrigen { get; set; }

        [Required(ErrorMessage = "El aero puerto de llegada es Obligatorio")]
        public int AeroPuertoDestino { get; set; }

        [Required(ErrorMessage = "La Fecha de salida es obligatoria")]
        public DateTime FechaHoraSalida { get; set; }

        [Required(ErrorMessage = "La Fecha de llegada es obligatoria")]
        public DateTime FechaHoraLlegada { get; set; }

        [Required(ErrorMessage = "La capacidad de la clase economica es obligatoria")]
        public int CapacidadClaseEconomica { get; set; }

        [Required(ErrorMessage = "La capacidad de la clase ejecutiva es obligatoria")]  
        public int CapacidadClaseEjecutiva { get; set; }
    }
}
