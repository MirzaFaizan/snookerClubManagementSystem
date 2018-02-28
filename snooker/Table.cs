using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace snooker
{
    class Table
    {
        private Player[] players { get; set; }
        private string matchType { get; set; }
        private string balls { get; set; }
        public Table(Player[] inPlayers,string inMatchType, string inBalls)
        {
            this.players = inPlayers;
            this.matchType = inMatchType;
            this.balls = inBalls;
        }

        public void endCurrentMatch()
        {
            // set defined rules here
        }
    }
}
