﻿using System;
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

        
       /* public static bool AgregarEvento()
        {
            
             bool resultado = true;

            try
            {
                string cadena = resources.conexion_PROYECTOv15;

                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "insert into PELICULA (code, titulo, estreno, precio, duracion, stock, descripcion, id_genero, id_director, id_usuario) values " +
                                   "(@code, @titulo, @estreno, @precio, @duracion, @stock, @descripcion, @id_genero, @id_director, @id_usuario)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@code", nueva.code);
                    command.Parameters.AddWithValue("@titulo", nueva.titulo);
                    command.Parameters.AddWithValue("@estreno", nueva.estreno);
                    command.Parameters.AddWithValue("@precio", nueva.precio);
                    command.Parameters.AddWithValue("@duracion", nueva.duracion);
                    command.Parameters.AddWithValue("@stock", nueva.stock);
                    command.Parameters.AddWithValue("@descripcion", nueva.descripcion);
                    command.Parameters.AddWithValue("@id_genero", nueva.id_genero);
                    command.Parameters.AddWithValue("@id_director", nueva.id_director);
                    command.Parameters.AddWithValue("@id_usuario", nueva.id_usuario);
                
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false;
            }

            return resultado;
        }*/

        /*public static List<Película> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<Película> lista = new List<Película>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT PELICULA.code, titulo, estreno, precio, duracion, stock, " +
                               "descripcion, GENERO.nombre AS 'genero', DIRECTOR.nombre AS 'director' " +
                               "FROM PELICULA " +
                               "INNER JOIN GENERO ON GENERO.code = PELICULA.id_genero " +
                               "INNER JOIN DIRECTOR ON DIRECTOR.code = PELICULA.id_director";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read())
                    {
                        Película peli = new Película();
                        peli.code = reader["code"].ToString();
                        peli.titulo = reader["titulo"].ToString();
                        peli.estreno = Convert.ToDateTime(reader["estreno"].ToString());
                        peli.precio = Convert.ToDouble(reader["precio"].ToString());
                        peli.duracion = Convert.ToInt32(reader["duracion"].ToString());
                        peli.stock = Convert.ToInt32(reader["stock"].ToString());
                        peli.descripcion = reader["descripcion"].ToString();
                        peli.id_genero = reader["genero"].ToString();
                        peli.id_director = reader["director"].ToString();
                        lista.Add(peli);
                    }   }
                connection.Close();
            }
            return lista;
        }
             */
        //}*/
    }
}
