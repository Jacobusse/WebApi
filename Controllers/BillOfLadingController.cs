namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
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

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> Locate(string id) {
        return Ok(await _service.Locate(new StandardIdentity(id)));
    }

    [HttpPost]
    public async Task<ActionResult<StandardIdentity>> Insert([FromBody] BillOfLading bol) {
        return Ok(await _service.Insert(bol));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<StandardIdentity>> Update(string id, [FromBody] BillOfLading bol) {
        return Ok(await _service.Update(new StandardIdentity(id), bol));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id) {
        await _service.Delete(new StandardIdentity(id));
        return Ok();
    }
}
