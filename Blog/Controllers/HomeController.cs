using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[Route("[controller]")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("Post")]
    public IActionResult Post()
    {
        return View();
    }

    [HttpGet]
    [Route("Edit")]
    public IActionResult Edit()
    {
        return View(new Post());
    }

    [HttpPost]
    [Route("Edit")]
    public IActionResult Edit(Post post)
    {
        return RedirectToAction(nameof(Index));
    }
}