using AutoMapper;
using DataAccessLayer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController(ProjectDbContext context, IMapper mapper) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var project = await context.Projects.FindAsync(id);

        if (project == null)
        {
            return NotFound("No project found.");
        }

        var result = mapper.Map<GithubProjectViewModel>(project);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var projects = await context.Projects.ToListAsync();

        if (projects == null || projects.Count == 0)
        {
            return NotFound("Error. No projects were found.");
        }

        var result = mapper.Map<List<GithubProjectViewModel>>(projects);

        return Ok(result);
    }
}
