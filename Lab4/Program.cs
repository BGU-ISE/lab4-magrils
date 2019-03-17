using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

namespace Lab4
{

    class Program
    {
        private static Hashtable database;
        



        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            ImplementLoggingFuntion();

            database.Add("sharon", "12345");
            database.Add("sharonM", "12345");
        }

        private static void ImplementLoggingFuntion()
        {
            /* We have 5 levels of log message. Let's test all.
             *  FATAL
                ERROR
                WARN
                INFO
                DEBUG
             */
            var secs = 3;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }

        public static bool Login()
        {
            bool login = false;
            int i = 0;
            while (i < 3 & !login)
            {
                i++;
                Console.WriteLine("Enter UserID");
                string userid = Console.ReadLine;
                Console.WriteLine("Enter UserID");
                string pswrd = Console.ReadLine;
                login = (database[userid]!=null && (string)database[userid]==pswrd);
            }

            if (login){
                Console.WriteLine("wrong password");
            }
            else
                Console.WriteLine("Hey " + userid);
            return login;


        }
            
    }
}
