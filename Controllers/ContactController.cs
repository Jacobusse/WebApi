namespace WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase {
    
    private IContactService _serviceUser;

    public ContactController(IContactService userService) {
        _serviceUser = userService;
    }

    [HttpPost]
    public async Task<ActionResult<StandardIdentity>> Insert([FromBody] Contact contact) {
        return Ok(await _serviceUser.Insert(contact));
    }

    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetAll() {
        return Ok(await _serviceUser.GetAll());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Contact>> Locate(string id) {
        return Ok(await _serviceUser.Locate(new StandardIdentity(id)));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<StandardIdentity>> Update(string id, [FromBody] Contact contact) {
        return Ok(await _serviceUser.Update(new StandardIdentity(id), contact));
    }

    [HttpPut()]
    public async Task<ActionResult<StandardIdentity>> Upsert([FromBody] Contact contact) {
        return Ok(await _serviceUser.Modify(contact));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(string id) {
        await _serviceUser.Delete(new StandardIdentity(id));
        return Ok();
    }
}