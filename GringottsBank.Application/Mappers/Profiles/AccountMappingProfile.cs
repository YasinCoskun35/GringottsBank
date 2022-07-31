using AutoMapper;
using GringottsBank.Application.Commands;
using GringottsBank.Application.Responses;
using GringottsBank.Core.Entities;


namespace GringottsBank.Application.Mappers.Profiles
{
    public class AccountMappingProfile:Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<Account, AccountResponse>().ReverseMap();
            CreateMap<Account, CreateAccountCommand>().ReverseMap();
        }
    }
}
