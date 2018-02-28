using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snooker
{
    class DatabaseFunctions
    {
        // Register Player
        public int saveNewPlayer(string name, string no)
        {
            string query = @"insert into players values('"+ no +"' , '"+name+"');";
            ConnectToDB ctd = new ConnectToDB();
            ctd.ConnectToDataBase();
            int res = ctd.UpdateQuery(query);
            ctd.CloseConnection();
            return res;
        }
        // Save Match Data

        /* write a function to save a single transaction data of a single match data { player name, no , date, time, bill} */

    }
}
