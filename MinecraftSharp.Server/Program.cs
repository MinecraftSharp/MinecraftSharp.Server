using MinecraftSharp.Server.Logic.MinecraftSharp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftSharp.Server
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.Title = "Minecraft# Server Host";
            Console.WriteLine("MinecraftSharp Server");
            string args;
            int ArgNumb = 0;
            foreach (string x in Args)
            {
                args = x;
                ArgNumb++;
            }
            if (ArgNumb == 2)
            {
                try
                {

                }
                catch
                {

                }
                StartServer(Args[0], Convert.ToInt32(Args[1]));
            }
            else
            {
                int Port = 0;
                try
                {
                    Console.WriteLine("Please enter a port to start your server on");
                    Port = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Invalid input format shutting down");
                    Console.ReadLine();
                }

                StartServer(GetIp(), Port);
                DoLoop();
            }
        }
        private static void StartServer(string IP, int Port)
        {
            try
            {

            }
            catch
            {

            }
            while (true)
            {

            }
        }
        private static void DoLoop()
        {
            string split = Console.ReadLine();
            string[] command = split.Split(' ');
            try
            {
                try
                {
                    Console.WriteLine(">" + Command.DoCommand(command[0], command[1], command[2]));
                }
                catch
                {
                    Console.WriteLine(">" + Command.DoCommand(command[0], command[1], null));
                }
            }
            catch
            {
                Console.WriteLine(">" + Command.DoCommand(command[0], null, null));
            }
            DoLoop();
        }
        private static string GetIp()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
    }
}
