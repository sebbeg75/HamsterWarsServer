using DataAccess.Data;
using DataAccess.Models;

namespace DataAccess.Services;

public class BattleRepository : IBattleRepository
{
    private readonly HamsterDbContext _context;

    public BattleRepository(HamsterDbContext context)
    {
        _context = context;
    }

    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public (Hamster, Hamster) GetContenders(List<Hamster> contenders)
    {
        if (contenders == null)
        {
            return (null, null);
        }
        else
        {
            Random random = new Random();

            Hamster contender1 = contenders[random.Next(0, contenders.Count)];
            Hamster contender2 = contenders[random.Next(0, contenders.Count)];

            while (contender1.Id == contender2.Id)
            {
                contender2 = contenders[random.Next(0, contenders.Count)];
            }
            return (contender1, contender2);
        }
    }

    public async Task DeleteBattle(int id)
    {
        var battle = await _context.Battles.FindAsync(id);
        if (battle is null)
        {
            throw new Exception("Sorry but no battle here.");
        }
        else
        {
            _context.Battles.Remove(battle);    
        }
        await _context.SaveChangesAsync();
    }

    public async Task AddAndUpdateHamster(int winnerId, int losserId)
    {
        Battle battle = new Battle();
        battle.WinnerId = winnerId;
        battle.LoserId = losserId;

        _context.Add(battle);
        await _context.SaveChangesAsync();


    }
}
