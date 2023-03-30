namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase {
    
    private IContactService _service;

    public ContactController(IContactService userService) {
        _service = userService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetAll() {
        return Ok(await _service.GetAll());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> Locate(string id) {
        return Ok(await _service.Locate(new StandardIdentity(id)));
    }

    [HttpPost]
    public async Task<ActionResult<StandardIdentity>> Insert([FromBody] Contact contact) {
        return Ok(await _service.Insert(contact));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<StandardIdentity>> Update(string id, [FromBody] Contact contact) {
        return Ok(await _service.Update(new StandardIdentity(id), contact));
    }

    [HttpPut()]
    public async Task<ActionResult<StandardIdentity>> Upsert([FromBody] Contact contact) {
        return Ok(await _service.Modify(contact));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id) {
        await _service.Delete(new StandardIdentity(id));
        return Ok();
    }
}