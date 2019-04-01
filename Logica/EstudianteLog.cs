using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Entidades;
using Dapper;


namespace Logica
{
   public class EstudianteLog
    {
        string connString = "server=DESKTOP-B6EFBEB\\SQLEXPRESS ; database=Matricula ; integrated security = true";
        public static List<EstudianteLog> estudiantes;

    }
}
