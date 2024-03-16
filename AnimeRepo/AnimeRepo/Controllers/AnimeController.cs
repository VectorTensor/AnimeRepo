using AnimeRepo.JsonDto;
using AnimeRepo.Service;
using Microsoft.AspNetCore.Mvc;

namespace AnimeRepo.Controllers;

public class AnimeController : Controller
{
    
    
    private AnimeService _animeService;


    public AnimeController(AnimeService animeService)
    {
        _animeService = animeService;
    }
    /// <summary>
    /// Get a random anime
    /// 0 -> Action
    /// 1-> Romance
    /// 2-> Comedy
    /// 3-> SOL
    /// 4-> Mystery 
    /// </summary>
    /// <returns></returns>
    [HttpGet("Anime")]
    [HttpGet("")]
    public AnimeGetDto Index()
    {

        return _animeService.GetRandomAnime();
        

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