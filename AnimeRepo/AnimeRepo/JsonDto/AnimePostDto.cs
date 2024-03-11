namespace AnimeRepo.JsonDto;

public class AnimePostDto
{
    
    
    public string AnimeName { get; set; }
    public List<EGenre> Genre { get; set; }

    public AnimePostDto(string a, List<EGenre> g)
    {
        AnimeName = a;
        Genre = g;
    }
    
    
}