using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendvjezba.Dtos;
using backendvjezba.Dtos.Character;

namespace backendvjezba
{
    public class AutoMapperProfile : Profile
    {



        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }

    }
}