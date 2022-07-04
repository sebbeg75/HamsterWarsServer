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
    public List<Battle> Battles { get; set; } = new List<Battle>();

    public async Task AddBattle(Battle battle)
    {
        _context.Battles.Add(battle);
        await _context.SaveChangesAsync();
    }

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

    public async Task UpdateBattle(Battle battle)
    {
        var DbBattle = await _context.Battles.FindAsync(battle.Id);

        DbBattle.WinnerId = battle.WinnerId;
        DbBattle.LoserId = battle.LoserId;
        await _context.SaveChangesAsync();
    }

    //public async Task AddNewBattle(Hamster hamsterWinner, Hamster hamsterLosser)
    //{
    //    Battle battle = new Battle
    //    {
    //        WinnerId = hamsterWinner.Id,
    //        LoserId = hamsterLosser.Id
    //    };
    //    _context.Battles.Add(battle);
    //    await _context.SaveChangesAsync();
    //}
}
