using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public abstract void DbConnect();

        public DbConnection(string connectionString)
        {
            if (connectionString == null || connectionString.Length == 0)
            {
                throw new ArgumentNullException();
            }
            else
            {
                ConnectionString = connectionString;
            }
        }
    }
}
