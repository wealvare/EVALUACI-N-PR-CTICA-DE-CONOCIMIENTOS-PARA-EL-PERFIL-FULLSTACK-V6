using Dapper;
using WebAPI_Wilber_Alvarez.Data;
using WebAPI_Wilber_Alvarez.Model;

namespace WebAPI_Wilber_Alvarez.Repository
{
    public class VueloRepository
    {
        private readonly IDbConnectionFactory _connection;

        public VueloRepository(IDbConnectionFactory connection)=> _connection = connection;

        public async Task<IEnumerable<Vuelo>> ObtenerTodo()
        {
            const string sql = "SELECT Id, NumeroVuelo, Aerolinea, AeroPuertoOrigen, AeroPuertoSalida, FechaHoraSalida, FechaHoraLlegada, CapacidadClaseEconomica, CapacidadClaseEjecutiva FROM AerolineaDb.dbo.Vuelo;";
            
            using var conn = _connection.CreateConnection();
            return await conn.QueryAsync<Vuelo>(sql);
        }

        public async Task<Vuelo?> ObtenerId(int id)
        {
            const string sql = @"SELECT Id, NumeroVuelo, Aerolinea, AeroPuertoOrigen, AeroPuertoSalida, FechaHoraSalida, FechaHoraLlegada, CapacidadClaseEconomica, CapacidadClaseEjecutiva FROM AerolineaDb.dbo.Vuelo WHERE Id = @Id;";
            using var conn = _connection.CreateConnection();
            return await conn.QueryFirstOrDefaultAsync<Vuelo>(sql, new { Id = id });
        }

        public async Task<int>Save (Vuelo vuelo)
        {
            const string sql = @"INSERT INTO AerolineaDb.dbo.Vuelo
                            (NumeroVuelo, Aerolinea, AeroPuertoOrigen, AeroPuertoSalida, FechaHoraSalida, 
                                FechaHoraLlegada, CapacidadClaseEconomica, CapacidadClaseEjecutiva)
                            VALUES(@NumeroVuelo, @Aerolinea, @AeroPuertoOrigen, @AeroPuertoSalida, @FechaHoraSalida, 
                                    @FechaHoraLlegada, @CapacidadClaseEconomica, @CapacidadClaseEjecutiva);";
            using var conn= _connection.CreateConnection();
            return await conn.ExecuteScalarAsync<int>(sql, vuelo);
        }

        public async Task<bool> Actualizar(Vuelo vuelo)
        {
            const string sql = @"UPDATE AerolineaDb.dbo.Vuelo
                                SET NumeroVuelo='@NumeroVuelo', Aerolinea=@Aerolinea, AeroPuertoOrigen=@AeroPuertoOrigen, AeroPuertoSalida=@AeroPuertoSalida, 
                                FechaHoraSalida=@FechaHoraSalida, FechaHoraLlegada='@FechaHoraLlegada', CapacidadClaseEconomica=@CapacidadClaseEconomica, 
                                   CapacidadClaseEjecutiva=@CapacidadClaseEjecutiva WHERE Id=0;";

            using var conn=  _connection.CreateConnection();
            var filasAfectadas= await conn.ExecuteAsync(sql, vuelo);
            return filasAfectadas > 0;
        }
    }
}
