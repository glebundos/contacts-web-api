using AutoMapper;
using contacts_web_api.Application.Commands;
using contacts_web_api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_web_api.Application.Mappers
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<CreateContactCommand, Contact>().ReverseMap();
        }
    }
}
