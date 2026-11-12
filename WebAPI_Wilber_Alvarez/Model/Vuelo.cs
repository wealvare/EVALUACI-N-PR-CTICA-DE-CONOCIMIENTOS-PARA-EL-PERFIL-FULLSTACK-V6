using System.ComponentModel.DataAnnotations;

namespace WebAPI_Wilber_Alvarez.Model
{
    public class Vuelo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NumeroDeVuelo { get; set; } = string.Empty;
        [Required]
        public int Aerolinea { get; set; }
        [Required]
        public int AeroPuertoOrigen {  get; set; }
        [Required]
        public int AeroPuertoDestino {  get; set; }
        [Required]
        public DateTime FechaHoraSalida { get; set; }
        [Required]
        public DateTime FechaHoraLlegada { get; set; }
        [Required]
        public int CapacidadClaseEconomica { get; set; }
        [Required]
        public int CapacidadClaseEjecutiva { get; set; }
    }
}
