using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace snooker
{
    public class Table
    {
        private List<Player> players { get; set; }
        private string matchType { get; set; }
        private string balls { get; set; }
        public Table(List<Player> inPlayers,string inMatchType, string inBalls)
        {
            this.players = inPlayers;
            this.matchType = inMatchType;
            this.balls = inBalls;
        }

        public Table() { }

        public void endCurrentMatch()
        {
            // set defined rules here
        }
    }
}
