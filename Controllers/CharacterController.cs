
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendvjezba.Dtos;
using backendvjezba.Dtos.Character;
using Microsoft.AspNetCore.Mvc;

namespace backendvjezba.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;


        // this is how we inject CharacterService intop controller
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }


        // get metohod  
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {

            return Ok(await _characterService.GetAllCharacters());
        }


        // paramtear mora biti dodat  unutar {}
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {

            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {

            var response = await _characterService.UpdateCharacter(updatedCharacter);

            if (response.Data is null)
            {
                return NotFound(response);

            }

            return Ok(response);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> DeleteCharacter(int id)
        {

            var response = await _characterService.DeleteCharacter(id);

            if (response.Data is null)
            {
                return NotFound(response);

            }

            return Ok(response);
        }



    }
}