using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public class HamsterDbContext : DbContext
{
    public HamsterDbContext(DbContextOptions<HamsterDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Hamsters
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 1,
            Name = "Belle",
            Age = 1,
            FavFood = "Apples",
            Loves = "Climbing",
            ImgName = "/images/hamster-1.jpg",  
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 2,
            Name = "Cleo",
            Age = 2,
            FavFood = "Bananas",
            Loves = "Snuggleing",
            ImgName = "/images/hamster-2.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 3,
            Name = "Evie",
            Age = 3,
            FavFood = "Broccoli",
            Loves = "Running",
            ImgName = "/images/hamster-3.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 4,
            Name = "Lola",
            Age = 4,
            FavFood = "Carrots",
            Loves = "Sleeping",
            ImgName = "/images/hamster-4.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 5,
            Name = "Daisy",
            Age = 1,
            FavFood = "Strawberries",
            Loves = "Climbing",
            ImgName = "/images/hamster-5.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 6,
            Name = "Penny",
            Age = 2,
            FavFood = "BlueBerries",
            Loves = "Climbing",
            ImgName = "/images/hamster-6.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 7,
            Name = "Ivy",
            Age = 3,
            FavFood = "Peanuts",
            Loves = "Sleeping",
            ImgName = "/images/hamster-7.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 8,
            Name = "Roxy",
            Age = 4,
            FavFood = "Potato",
            Loves = "Climbing",
            ImgName = "/images/hamster-8.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 9,
            Name = "Zoe",
            Age = 2,
            FavFood = "Seeds",
            Loves = "Snuggleing",
            ImgName = "/images/hamster-9.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 10,
            Name = "Duncan",
            Age = 1,
            FavFood = "Grapes",
            Loves = "Snuggleing",
            ImgName = "/images/hamster-10.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 11,
            Name = "Frodo",
            Age = 2,
            FavFood = "Banana",
            Loves = "Climbing",
            ImgName = "/images/hamster-11.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 12,
            Name = "Jasper",
            Age = 3,
            FavFood = "Strawberries",
            Loves = "Running",
            ImgName = "/images/hamster-12.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 13,
            Name = "Jojo",
            Age = 4,
            FavFood = "Spinach",
            Loves = "Climbing",
            ImgName = "/images/hamster-13.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 14,
            Name = "Max",
            Age = 1,
            FavFood = "Hay",
            Loves = "Climbing",
            ImgName = "/images/hamster-14.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 15,
            Name = "Gomez",
            Age = 2,
            FavFood = "Broccoli",
            Loves = "Running",
            ImgName = "/images/hamster-15.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 16,
            Name = "Felix",
            Age = 3,
            FavFood = "Carrot",
            Loves = "Climbing",
            ImgName = "/images/hamster-16.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 17,
            Name = "Frodo",
            Age = 4,
            FavFood = "Apples",
            Loves = "Climbing",
            ImgName = "/images/hamster-17.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 18,
            Name = "Rocky",
            Age = 5,
            FavFood = "Cucumber",
            Loves = "Sleeping",
            ImgName = "/images/hamster-18.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 19,
            Name = "Frizy",
            Age = 2,
            FavFood = "Apples",
            Loves = "Snuggleing",
            ImgName = "/images/hamster-19.jpg",
        });
        modelBuilder.Entity<Hamster>().HasData(new Hamster
        {
            Id = 20,
            Name = "Nemo",
            Age = 5,
            FavFood = "Cucumber",
            Loves = "Sleeping",
            ImgName = "/images/hamster-20.jpg",
        });
    }

    public DbSet<Hamster> Hamsters { get; set; }
    public DbSet<Battle> Battles { get; set; }
}
