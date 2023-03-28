using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class BillOfLadingController : Controller {

    private IBillOfLadingService _service;

    public BillOfLadingController(IBillOfLadingService service)    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<BillOfLading>>> GetAll() {
        return Ok(await _service.GetAll());
    }

}
