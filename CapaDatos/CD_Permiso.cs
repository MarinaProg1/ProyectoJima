﻿using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int IdUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (var conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                   StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol,p.NombreMenu from Permiso p");
                    query.AppendLine("inner join Rol r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join Usuario u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @IdUsuario"); 



                    SqlCommand cmd = new SqlCommand(query.ToString(), conn);
                    cmd.Parameters.AddWithValue("@idUsuario", IdUsuario);   
                    cmd.CommandType = CommandType.Text;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso
                            {
                                oRol = new Rol() {IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    lista = new List<Permiso>();
                }
            }
            return lista;

        }
    }
}
