namespace AnimeRepo.Models;

public class AnimeModel
{
    public int AnimeModelId{ get; set; }
    public string AnimeName { get; set; }
    public ICollection<GenreModel> Genre { get; set; }
    
}