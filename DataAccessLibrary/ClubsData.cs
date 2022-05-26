using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ClubsData : IClubsData
    {
        private readonly ISqlDataAccess db;

        public ClubsData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<ClubModel>> GetClub()
        {
            string sql = "select * from dbo.Clubs";
            return db.LoadData<ClubModel, dynamic>(sql, new { });
        }

        public Task InsertClub(ClubModel club)
        {
            string sql = @"insert into dbo.Clubs (ClubName, FoundationDate)
                            values (@ClubName, @FoundationDate);";
            return db.SaveData(sql, club);
        }


    }
}
