using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace DiscordInviteGen
{
    class Program
    {
        static void Main(string[] args)
        {
        Time:
            Console.WriteLine("Input the time (In MS) you want the code's to be delayed. Input 0 for no delay.");
            var time = Console.ReadLine();
            bool isInt = time.All(char.IsDigit);
            if (isInt == false)
            {
                Console.WriteLine("You need to input a number");
                goto Time;
            }
            int sleep = Convert.ToInt32(time);
        Gen:
            Random random = new Random();
            string url = "https://discord.gg/";
            string link = "";

            string dict = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

            for (int i = 0; i < 8; i++)
            {
                link += dict[random.Next(0, dict.Length - 1)];
            }

            string server = url + link;
            Console.WriteLine(server);
            System.Threading.Thread.Sleep(sleep);
            goto Gen;

        }
    }
}
