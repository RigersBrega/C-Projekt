using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLogin
{
    public class Constants
    {
        static public String dbPath = System.Environment.CurrentDirectory.ToString() + "\\Database.mdf";
        static public String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                          "AttachDbFilename="+dbPath+";" +
                          "Integrated Security=True;" +
                          "Connect Timeout=3;" +
                          "User Instance= False";
    }
}
