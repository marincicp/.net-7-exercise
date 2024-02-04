using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendvjezba.Dtos;
using backendvjezba.Dtos.Character;
// using backendvjezba.Dtos;
// using backendvjezba.Dtos;
// using backendvjezba.Dtos.Character;

namespace backendvjezba.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto character);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}