using System.ComponentModel.DataAnnotations;

namespace WebAPI_Wilber_Alvarez.Dto.Response
{
    public class VueloResponseDto
    {
        public int Id { get; set; }

        public int Aerolinea { get; set; }

        public string NumeroDeVuelo { get; set; } = string.Empty;

        public int AeroPuertoOrigen { get; set; }

        public int AeroPuertoDestino { get; set; }

        public DateTime FechaHoraSalida { get; set; }

        public DateTime FechaHoraLlegada { get; set; }

        public int CapacidadClaseEconomica { get; set; }

        public int CapacidadClaseEjecutiva { get; set; }
    }
}
