using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IPlayersData
    {
        Task<List<PlayerModel>> GetPlayer();
        Task InsertPlayer(PlayerModel player);
    }
}