using System.Data.SqlClient;
using apiServicio.Business.Contracts;
using apiServicio.Models;


namespace apiServicio.Business.Clases
{
    public class RolRepository : IRolRepository
    {
        private readonly String conncec;
        public RolRepository (IConfiguration configuration)
        {
            conncec = configuration.GetConnectionString("conBase");
        }

        public async Task<List<Rol>> GetList ()
        {
            List<Rol> list = new List<Rol>();
            Rol l;
            using (SqlConnection conn = new SqlConnection (conncec))
            {
                await conn.OpenAsync ();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rol;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        l = new Rol();
                        l.Id = Convert.ToInt32(reader["Id"]);
                        l.NombreRol = Convert.ToString(reader["NombreRol"]);
                        list.Add(l);
                    }
                }
            }
                return list;

        }
    }
}
