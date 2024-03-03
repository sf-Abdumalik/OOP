using System.Net.NetworkInformation;
using System.Collections.Generic;  

using System.Linq;

using System.Text;

using System.Net.WebSockets;


namespace Daris_8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteString("Assalomu alekum");

            string a = ReturnString("Assalomu", "alekum!");
            Console.WriteLine(a);
        }

    }    
}