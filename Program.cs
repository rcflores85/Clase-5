using System;
using System.Collections.Generic;
using System.Threading;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando el programa: {0}", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            GetUsersList();
            Console.WriteLine("Imprimiendo este mensaje");
            GetRolesList();
        }

        public static void GetUsersList()
        {
            Console.WriteLine("Obteniendo usuarios de la BD...");
            List<string> users = GetUsersListFromDB();
            Console.WriteLine("La cantidad total de usuarios es: {0} - {1}", users.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        public static void GetRolesList()
        {
            Console.WriteLine("Obteniendo roles de la BD...");
            List<string> roles = GetRolesListFromDB();
            Console.WriteLine("La cantidad total de roles es: {0} - {1}", roles.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
        }

        public static List<string> GetUsersListFromDB()
        {
            Thread.Sleep(3000);
            return new List<string>(new [] {"jperez", "llopez"});
        }

        public static List<string> GetRolesListFromDB()
        {
            Thread.Sleep(2000);
            return new List<string>(new [] {"administrador", "usuario"});
        }
    }
}
