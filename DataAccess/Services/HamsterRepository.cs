using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class HamsterRepository : IHamsterRepository
{
    private readonly HamsterDbContext _context;

    public HamsterRepository(HamsterDbContext context)
    {
        _context = context;
    }

    public List<Hamster> Hamsters { get; set; } = new List<Hamster>();

    public async Task<List<Hamster>> GetHamsters()
    {
        Hamsters = await _context.Hamsters.ToListAsync();
        return Hamsters;
    }

    public async Task<Hamster> GetHamsterById(int id)
    {
        var hamster = await _context.Hamsters.FindAsync(id);
        if (hamster is null)
            throw new Exception("Sorry but no hamster here.");
        return hamster;
    }

    public async Task AddHamster(Hamster hamster)
    {
        _context.Add(hamster);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteHamster(int id)
    {
        var hamster = await _context.Hamsters.FindAsync(id);
        if (hamster is null)
        {
            throw new Exception("Sorry but no hamster here.");
        }
        else
        {
            _context.Hamsters.Remove(hamster);
        }
        await _context.SaveChangesAsync();
    }

    public async Task UpdateHamster(Hamster hamster)
    {
        var DbHamster = await _context.Hamsters.FindAsync(hamster.Id);

        DbHamster.Name = hamster.Name;
        DbHamster.Age = hamster.Age;
        DbHamster.FavFood = hamster.FavFood;
        DbHamster.Loves = hamster.Loves;
        DbHamster.ImgName = hamster.ImgName;
        DbHamster.Wins = hamster.Wins;
        DbHamster.Losses = hamster.Losses;
        DbHamster.Games = hamster.Games;

        await _context.SaveChangesAsync(); 
    }
}
