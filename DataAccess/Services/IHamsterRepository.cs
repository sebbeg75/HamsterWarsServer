using DataAccess.Models;

namespace DataAccess.Services;

public interface IHamsterRepository
{
    List<Hamster> Hamsters { get; set; }
    Task<List<Hamster>> GetHamsters();
    Task<Hamster> GetHamsterById(int id);
    Task AddHamster(Hamster hamster);
    Task DeleteHamster(int id);
    Task UpdateHamster(Hamster hamster);
}