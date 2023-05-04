using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TUBESKPL_BackEnd_
{
    internal class Program
    {
        static void Main(string[] args)
        {
         PeminjamanService peminjamanService = new PeminjamanService();

            List<String> a = peminjamanService.checkBukuyngAkanDipinjam(4);
            Console.WriteLine(a[1]);

        }
    }
}
