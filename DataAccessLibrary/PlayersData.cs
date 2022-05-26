using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PlayersData : IPlayersData
    {
        private readonly ISqlDataAccess _db;

        public PlayersData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PlayerModel>> GetPlayer()
        {
            string sql = "select * from dbo.Players";
            return _db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task InsertPlayer(PlayerModel player)
        {
            string sql = @"insert into dbo.Players (FirstName, LastName, Age, Nationality)
                            values (@FirstName, @LastName, @Age, @Nationality);";
            return _db.SaveData(sql, player);
        }


    }
}
