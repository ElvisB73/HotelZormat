using Hotel.Negocio_.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio_.DaL
{
    public class HabitacionDAL
    {
        // Lee el connection string del App.config (nombre "HotelBae")
        private string connectionString =
            ConfigurationManager.ConnectionStrings["HotelBae"].ConnectionString;

        // ── Trae todas las habitaciones ──────────────────────────────
        public List<Habitacion> ObtenerTodas()
        {
            List<Habitacion> lista = new List<Habitacion>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT NUMERO, TIPO, PISO, ESTADO, CAPACIDAD FROM HABITACIONES ORDER BY NUMERO";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(MapearHabitacion(reader));
                }
            }

            return lista;
        }

        // ── Trae solo las habitaciones de un piso ───────────────────
        public List<Habitacion> ObtenerPorPiso(int piso)
        {
            List<Habitacion> lista = new List<Habitacion>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT NUMERO, TIPO, PISO, ESTADO, CAPACIDAD FROM HABITACIONES WHERE PISO = @Piso ORDER BY NUMERO";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Piso", piso);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(MapearHabitacion(reader));
                }
            }

            return lista;
        }

        // ── Busca una habitación por número ─────────────────────────
        public Habitacion BuscarPorNumero(int numero)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT NUMERO, TIPO, PISO, ESTADO, CAPACIDAD FROM HABITACIONES WHERE NUMERO = @Numero";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Numero", numero);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return MapearHabitacion(reader);
            }

            return null; // No encontrada
        }

        // ── Actualiza el estado de una habitación ───────────────────
        public void ActualizarEstado(int numero, string nuevoEstado)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE HABITACIONES SET ESTADO = @Estado WHERE NUMERO = @Numero";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@Numero", numero);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ── Mapea un registro del reader a un objeto Habitacion ──────
        private Habitacion MapearHabitacion(SqlDataReader reader)
        {
            return new Habitacion
            {
                Numero = Convert.ToInt32(reader["NUMERO"]),
                Tipo = reader["TIPO"].ToString(),
                Piso = Convert.ToInt32(reader["PISO"]),
                Estado = reader["ESTADO"].ToString(),
                Capacidad = Convert.ToInt32(reader["CAPACIDAD"])
                // Tarifa no está en BD, se calcula en ObtenerTarifa()
            };
        }
    }
}
