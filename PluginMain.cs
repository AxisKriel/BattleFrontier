using System;
using System.Collections.Generic;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using TShockAPI.DB;

namespace BattleFrontier
{
    [ApiVersion(1, 14)]
    public class PluginMain : TerrariaPlugin
    {
        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("bf.sendmessage", BpSendMessage, "sendmessage"));
            //Commands.ChatCommands.Add(new Command("bf.bp.check", BpCheck, "battlepass")); // Has player and admin versions
            //Commands.ChatCommands.Add(new Command("bf.bp.tier", BpTier, "tier"));
            //Commands.ChatCommands.Add(new Command("bf.points.give", PointsGive, "pgive"));
            //Commands.ChatCommands.Add(new Command("bf.points.score", BpHighscore, "highscore")); // Has player and admin versions
            //Commands.ChatCommands.Add(new Command("bf.points.store", BpStore, "pstore"));
            //Commands.ChatCommands.Add(new Command("bf.other.admin", BpMod, "bpmod"));
            //Commands.ChatCommands.Add(new Command("bf.other.admin", PMod, "pmod"));
            ////Commands.ChatCommands.Add(new Command("bf.other.admin", BfReload, "bfreload"));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }

        public override Version Version
        {
            get { return new Version("1.0"); }
        }


        public override string Name
        {
            get { return "Battle Frontier"; }
        }


        public override string Author
        {
            get { return "Enerdy"; }
        }


        public override string Description
        {
            get { return "Battle Frontier Point System"; }
        }


        public PluginMain(Main game)
            : base(game)
        {
        }

        public static void BpSendMessage(CommandArgs args) // Tests on sendmessage
        {
            string message = args.Parameters[0];
            var times = Int32.Parse(args.Parameters[1]);

            
            if (args.Parameters.Count > 1 && args.Parameters.Count < 3)
            {
                for (int i = 0; i < times; i++)
                {
                    args.Player.SendMessage(string.Format("Message: {0} | You've received this message {1} times!", message, i + 1), Color.SkyBlue);
                }
            }
            else
            {
                args.Player.SendErrorMessage("Invalid arguments! Syntax: /sendmessage <message> <times>");
            }
        }
        


        
    }
}
