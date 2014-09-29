using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace HomeSurfer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Initializing Database...");
            
            try
            {
                DataContext dataContext = new DataContext();
                dataContext.Database.Initialize(true);
            }
            catch (Exception e)
            {

                System.Console.WriteLine(string.Format("Error: {0}",e.Message));
                System.Console.ReadLine();
            }
            
            System.Console.WriteLine("Done...");
            System.Console.ReadLine();
        }
    }
}
