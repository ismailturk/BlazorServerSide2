using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CoachsData : ICoachsData
    {
        private readonly ISqlDataAccess db;

        public CoachsData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<CoachModel>> GetCoach()
        {
            string sql = "select * from dbo.Coach";
            return db.LoadData<CoachModel, dynamic>(sql, new { });
        }

        public Task InsertCoach(CoachModel coach)
        {
            string sql = @"insert into dbo.Coach (FirstName, LastName, Age, Nationality)
                            values (@FirstName, @LastName, @Age, @Nationality);";
            return db.SaveData(sql, coach);
        }
    }
}
