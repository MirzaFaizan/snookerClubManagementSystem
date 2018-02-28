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
        private Stopwatch timer;
        private DateTime datetime;
        private string matchType { get; set; }
        private string balls { get; set; }
        private string totalBill { get; set; }
        public Table(Player[] inPlayers,string inMatchType, string inBalls)
        {
            this.players = inPlayers;
            this.timer.Start();
        }

        public void endCurrentMatch()
        {
            // set defined rules here
        }
    }
}
