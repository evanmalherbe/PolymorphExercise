using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("string");
            sqlConnection.DbConnect();

            OracleConnection oracleConnection = new OracleConnection("string");
            oracleConnection.DbConnect();
        }
    }
}
