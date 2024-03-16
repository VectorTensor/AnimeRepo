using AnimeRepo.Data;
using AnimeRepo.JsonDto;
using AnimeRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeRepo.Service;

public class AnimeService
{
    private ApplicationDbContext _context;

    public AnimeService(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }

    public AnimeGetDto GetRandomAnime()
    {
        int n = _context.AnimeModels.Count();

        Random rnd = new Random();
        int num = rnd.Next(1,n+1);
        //var x = _context.AnimeModels.Where(x => x.AnimeModelId == num).Select(y=> y.Genre.Select(x=> x.GenreName)).SingleOrDefault();
        
        var y = _context.AnimeModels.Where(x => x.AnimeModelId == num).Select(y=> new AnimeGetDto{
            AnimeName = y.AnimeName,
        Genre = y.Genre.Select(x=> (EGenre)x.GenreModelId -1 ).ToList()}).SingleOrDefault();
        return y;

    }
}