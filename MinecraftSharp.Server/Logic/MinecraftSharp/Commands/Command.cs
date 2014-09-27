using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftSharp.Server.Logic.MinecraftSharp.Commands
{
    public class Command
    {
        public static string DoCommand(string Command, string player1, string player2)
        {
            Command = DoFix(Command);
            Command = Command.ToLower();
            string PlayerAffect;
            string PlayerGoto;
            Nullable<bool> OnePlayer = false;
            try
            {
                if (!String.IsNullOrEmpty(player1))
                {
                    PlayerAffect = player1;
                    OnePlayer = true;
                }
            }
            catch
            {
                return "Error in doing command. Did you specify enough args";
            }
            try
            {
                if (!String.IsNullOrEmpty(player2))
                {
                    PlayerGoto = player2;
                    OnePlayer = false;
                }
            }
            catch { }

            if (Command == "spawn")
            {
                if ((bool)OnePlayer)
                {
                    ///Command
                    return "Player teleported to spawn";
                }
                else
                    return "Invalid input format. Only one player can be teleported to spawn at a time";
            }
            else if (Command == "ban")
            {
                if ((bool)OnePlayer)
                {
                    ///Command
                    return "Player banned";
                }
                else
                    return "Invalid input format. Only one player can be banned at a time";
            }
            else if (Command == "kick")
            {
                if ((bool)OnePlayer)
                {
                    ///Command
                    return "Player kicked";
                }
                else
                    return "Invalid input format. Only one player can be kicked at a time";
            }
            else if (Command == "quit")
            {
                Console.WriteLine("Are you sure you want to shut down the server Yes/No");
                var result = Console.ReadLine();
                if (result.ToLower() == "yes")
                {
                    Console.WriteLine("Shutting down the server. Saving your maps");
                    Console.WriteLine("Maps saved. Press enter to quit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            return "The command \"" + Command + "\" had an error casting. Please try \"Help\" or \"?\"";
        }
        public static string DoFix(string CommandRex)
        {
            if (CommandRex.Contains("//"))
            {
                
            }
            else if (CommandRex.Contains("/"))
            {
                CommandRex.Replace("/", "");
            }
            return CommandRex;
        }
    }
}
