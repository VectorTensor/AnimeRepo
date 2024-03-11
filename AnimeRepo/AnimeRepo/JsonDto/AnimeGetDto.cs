namespace AnimeRepo.JsonDto;

public class AnimeGetDto
{
    public string AnimeName { get; set; }
    public List<EGenre> Genre { get; set; }

    public AnimeGetDto(string a, List<EGenre> g)
    {
        AnimeName = a;
        Genre = g;
    }
    

}