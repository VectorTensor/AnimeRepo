namespace AnimeRepo.Models;

public class GenreModel
{
    public int GenreModelId{ get; set; }
    public string GenreName { get; set; }
    public ICollection<AnimeModel> AnimeModels { get; set; }
}