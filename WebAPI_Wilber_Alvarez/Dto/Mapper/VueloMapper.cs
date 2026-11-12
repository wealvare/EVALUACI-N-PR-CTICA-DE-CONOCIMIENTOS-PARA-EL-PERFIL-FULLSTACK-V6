using WebAPI_Wilber_Alvarez.Dto.Requets;
using WebAPI_Wilber_Alvarez.Dto.Response;
using WebAPI_Wilber_Alvarez.Model;

namespace WebAPI_Wilber_Alvarez.Dto.Mapper
{
    public static class VueloMapper
    {
        public static Vuelo ToEntity(this VueloRequetsDto dto) => new()
        {
            NumeroDeVuelo = dto.NumeroDeVuelo,
            Aerolinea = dto.Aerolinea,
            AeroPuertoOrigen = dto.AeroPuertoOrigen,
            AeroPuertoDestino = dto.AeroPuertoDestino,
            FechaHoraSalida = dto.FechaHoraSalida,
            FechaHoraLlegada = dto.FechaHoraLlegada,
            CapacidadClaseEconomica = dto.CapacidadClaseEconomica,
            CapacidadClaseEjecutiva = dto.CapacidadClaseEjecutiva
        };

        public static IEnumerable<VueloResponseDto> ToDto(this IEnumerable<Vuelo> vuelos)=>vuelos.Select(v=> v.ToDto());

        public static VueloResponseDto ToDto(this Vuelo vuelo) => new()
        {
            Id = vuelo.Id,
            NumeroDeVuelo = vuelo.NumeroDeVuelo,
            Aerolinea= vuelo.Aerolinea,
            AeroPuertoOrigen = vuelo.AeroPuertoOrigen,
            AeroPuertoDestino = vuelo.AeroPuertoDestino,
            FechaHoraSalida = vuelo.FechaHoraSalida,
            FechaHoraLlegada = vuelo.FechaHoraLlegada,
            CapacidadClaseEconomica = vuelo.CapacidadClaseEconomica,
            CapacidadClaseEjecutiva = vuelo.CapacidadClaseEjecutiva
        };

        public static Vuelo ToEntity(this ActualizarVuelo dto, int id) => new()
        {
            Id = dto.Id,
            NumeroDeVuelo = dto.NumeroDeVuelo,
            Aerolinea = dto.Aerolinea,
            AeroPuertoOrigen = dto.AeroPuertoOrigen,
            AeroPuertoDestino = dto.AeroPuertoDestino,
            FechaHoraSalida = dto.FechaHoraSalida,
            FechaHoraLlegada = dto.FechaHoraLlegada,
            CapacidadClaseEconomica = dto.CapacidadClaseEconomica,
            CapacidadClaseEjecutiva = dto.CapacidadClaseEjecutiva
        };
    }
}
