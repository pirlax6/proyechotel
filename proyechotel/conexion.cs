using MySql.Data.MySqlClient;

namespace proyectohotel
{
    internal class Conexion
    {
        public static MySqlConnection conexion = new MySqlConnection(
            "server=localhost;database=HotelDB;user=root;password=prime1234;"
        );
    }
}