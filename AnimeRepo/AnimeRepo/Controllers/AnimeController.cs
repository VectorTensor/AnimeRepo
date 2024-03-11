using AnimeRepo.JsonDto;
using Microsoft.AspNetCore.Mvc;

namespace AnimeRepo.Controllers;

public class AnimeController : Controller
{
    [HttpGet("Anime")]
    [HttpGet("")]
    public AnimeGetDto Index()
    {

        return new AnimeGetDto("Naruto", new List<EGenre>() { EGenre.Action, EGenre.Comedy });


    }

    [HttpPost("Anime/Add")]
    public IActionResult AddAnime([FromBody] AnimePostDto anime)
    {

        if (anime == null)
        {
            return BadRequest();
        }
        
        return Ok(anime);
    }
}