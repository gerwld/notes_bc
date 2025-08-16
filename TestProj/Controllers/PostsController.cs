using Microsoft.AspNetCore.Mvc;
using TestProj.Models;

namespace TestProj.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PostsController : Controller
{
    [HttpPost]
    public object Create(PostModel model)
    {
        
    }
    [HttpPatch]
    public object Update(PostModel model)
    {
        
    }
    [HttpGet("{id}")]
    public object Get(int id)
    {
        
    }
    [HttpGet]
    public object GetAll()
    {
        
    }
    [HttpDelete("{id}")]
    public object Delete(int id)
    {
        
    }
}