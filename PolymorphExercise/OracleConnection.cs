using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }
        public override void DbConnect()
        {
            Console.WriteLine("Connect to Oracle db");
        }
    }
}
