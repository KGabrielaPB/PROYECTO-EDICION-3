using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Resources; 


namespace PROYECTO_BINAES
{
    internal class EventoDAO
    {        
       public static bool AgregarEvento(int id, string titulo, string objetivo,int cantidad, int id_horarioevento, DateTime f_h_apertura, DateTime f_h_cierre)
        {
            
             bool resultado = true;

            try
            {
                Evento evento = new Evento(); 
                string cadena = "Integrated Security = True; Initial Catalog = PROYECTOv15; Data Source = ALEXANDRARIVERA";
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO EVENTO(id, titulo, objetivo, cantidad)" + "VALUES(@id, @titulo, @objetivo,@cantidad);" + 
                        "INSERT INTO HORARIOEVENTO (id as idHorarioEvento, f_h_abertura, f_h_cierre) VALUES (@idEventos, @fechaabertura, @fechacierre)"; 
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@titulo", titulo);
                    command.Parameters.AddWithValue("@objetivo", objetivo);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    //command.Parameters.AddWithValue("@id_horarioevento", id_horarioevento);
                    command.Parameters.AddWithValue("@idEventos", id_horarioevento);
                    command.Parameters.AddWithValue("@fechaabertura", f_h_apertura);
                    command.Parameters.AddWithValue("@fechacierre", f_h_cierre);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }

        public static List<Evento> ObtenerEventos()
        {
            List<Evento> listaEventos = new List<Evento>();

  
            string cadena = "Integrated Security = True; Initial Catalog = PROYECTOv15; Data Source = ALEXANDRARIVERA"; 
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT e.id, e.titulo, e.objetivo, e.cantidad, e.id_horarioevento, h.id as idEvento,h.f_h_apertura, h.f_h_cierre FROM EVENTO e INNER JOIN HORARIOEVENTO h ON e.id_horarioevento = h.id; ";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento nuevoevento = new Evento();
                        nuevoevento.Id = Convert.ToInt32(reader["id"].ToString());
                        nuevoevento.Titulo = reader["titulo"].ToString();
                        nuevoevento.Objetivo = reader["objetivo"].ToString();
                        nuevoevento.Cantidad = Convert.ToInt32(reader["cantidad"].ToString());
                        //nuevoevento.Id_HorarioEvento = Convert.ToInt32(reader["id_horarioevento"].ToString());
                        nuevoevento.IdHorarioEvento = Convert.ToInt32(reader["idEvento"].ToString());
                        nuevoevento.F_h_Apertura = Convert.ToDateTime(reader["f_h_apertura"].ToString());
                        nuevoevento.F_h_Cierre = Convert.ToDateTime(reader["f_h_cierre"].ToString());
                        listaEventos.Add(nuevoevento); 
                    }
                    connection.Close();
                }
                return listaEventos;
            }

        }
    }
}
