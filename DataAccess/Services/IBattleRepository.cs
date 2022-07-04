using DataAccess.Models;

namespace DataAccess.Services;

public interface IBattleRepository
{
    List<Hamster> Hamsters { get; set; }
    (Hamster, Hamster) GetContenders(List<Hamster> contenders);
    Task AddAndUpdateHamster(int losserId, int winnerId);
    Task DeleteBattle(int id);
}
