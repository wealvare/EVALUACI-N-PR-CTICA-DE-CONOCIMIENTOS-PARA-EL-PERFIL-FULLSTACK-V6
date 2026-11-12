using WebAPI_Wilber_Alvarez.Dto.Mapper;
using WebAPI_Wilber_Alvarez.Dto.Requets;
using WebAPI_Wilber_Alvarez.Dto.Response;
using WebAPI_Wilber_Alvarez.Repository;

namespace WebAPI_Wilber_Alvarez.Service
{
    public class VueloService
    {
        public readonly VueloRepository _repository;

        public VueloService (VueloRepository repository)=> _repository = repository;

        public async Task<IEnumerable<VueloResponseDto>> obtener()
        {
            var vuelo =await _repository.ObtenerTodo();
            return vuelo.ToDto();
        }

        public async Task<VueloResponseDto>Guardar(VueloRequetsDto dto)
        {
            var vuelo= dto.ToEntity();
            vuelo.Id = await _repository.Save(vuelo);
            return vuelo.ToDto() ;
        }

        public async Task <VueloResponseDto?> Actualizar (int id, ActualizarVuelo dto)
        {
            var vuelo = dto.ToEntity(id);

            var actualizado = await _repository.Actualizar(vuelo);
            if (!actualizado)
                return null;

            var resultado = await _repository.ObtenerId(id);
            return resultado?.ToDto();
        }


    }
}
