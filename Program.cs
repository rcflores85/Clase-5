using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando el programa: {0}", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            //GetUsersList();
            //GetRolesList();

            GetUsersListAsync();
            GetRolesListAsync();

            Console.WriteLine("Imprimiendo este mensaje");
            Console.ReadLine();
        }

        public static async Task GetUsersListAsync()
        {
            try
            {
                Console.WriteLine("Obteniendo usuarios de la BD en forma asincronica...");
                List<string> users = await GetUsersListFromDBAsync();
                Console.WriteLine("La cantidad total de usuarios es: {0} - {1}", users.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));            
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static async Task<List<string>> GetUsersListFromDBAsync()
        {
            await Task.Delay(3000); //simulando demora DB
            return new List<string>(new [] {"jperez", "llopez"});
        }

        public static async Task GetRolesListAsync()
        {
            Console.WriteLine("Obteniendo roles de la BD en forma asincronica...");
            List<string> roles = await GetRolesListFromDBAsync();
            Console.WriteLine("La cantidad total de roles es: {0} - {1}", roles.Count, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));            
        }

        private static async Task<List<string>> GetRolesListFromDBAsync()
        {
            await Task.Delay(2000); //simulando demora DB
            return new List<string>(new [] {"administrator", "user"});
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
