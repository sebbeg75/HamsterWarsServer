using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Battle
{
    public int Id { get; set; }
    public int WinnerId { get; set; }
    public int LoserId { get; set; }
}
 