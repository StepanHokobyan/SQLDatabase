using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Db_commands.getHumans())
            {

                Console.WriteLine(item.Id + "    " + item.Name + "   " + item.GroupName + "   " + item.ModeDate);
            }
        }
    }
}
