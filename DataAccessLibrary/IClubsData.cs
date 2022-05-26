using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IClubsData
    {
        Task<List<ClubModel>> GetClub();
        Task InsertClub(ClubModel club);
    }
}