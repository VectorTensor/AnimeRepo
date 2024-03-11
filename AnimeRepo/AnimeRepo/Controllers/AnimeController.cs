using AnimeRepo.JsonDto;
using Microsoft.AspNetCore.Mvc;

namespace AnimeRepo.Controllers;

public class AnimeController : Controller
{
    [Route("Anime")]
    public AnimeGetDto Index()
    {

        return new AnimeGetDto("Naruto", new List<EGenre>() { EGenre.Action, EGenre.Comedy });


    }
}