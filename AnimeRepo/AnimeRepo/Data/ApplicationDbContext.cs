using AnimeRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeRepo.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<GenreModel> GenreModels { get; set; }
    public DbSet<AnimeModel> AnimeModels { get; set; }
}