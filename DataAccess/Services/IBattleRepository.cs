using DataAccess.Models;

namespace DataAccess.Services;

public interface IBattleRepository
{
    List<Hamster> Hamsters { get; set; }
    Task AddBattle(Battle battle);
    //Task AddNewBattle(Hamster hamsterWinner, Hamster hamsterLosser);
    (Hamster, Hamster) GetContenders(List<Hamster> contenders);
    Task UpdateBattle(Battle battle);
    Task DeleteBattle(int id);
}
