﻿using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class UsuarioDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Ejercicio3; Uid=root; Pwd=Marya10;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string codigo, string clave) 
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);  
                cmd.Parameters.AddWithValue("Codigo", codigo);  
                cmd.Parameters.AddWithValue("Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.PrimerNombre = reader[1].ToString();   
                    user.PrimerApellido = reader[2].ToString();
                    user.Rol = reader[3].ToString();    
                    user.Clave = reader[4].ToString();
                    user.EstaActivo = Convert.ToBoolean(reader[5]);
                }
                reader.Close();
                conn.Close();   

            }
            catch (Exception ex)
            {

            }
            return user;
        }
        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
            }
            catch (Exception ex)
            {

            }
            return listaUsuariosDT;
        }
    }
}
