namespace AnimeRepo.JsonDto;

public class AnimePostDto
{
    
    
    public string AnimeName { get; set; }
    public List<int> Genre { get; set; }
    public AnimePostDto(string a, List<int> g)
    {
        AnimeName = a;
        Genre = g;
    }

    public AnimePostDto()
    {
    }
    
}