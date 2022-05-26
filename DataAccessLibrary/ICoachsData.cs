using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ICoachsData
    {
        Task<List<CoachModel>> GetCoach();
        Task InsertCoach(CoachModel coach);
    }
}