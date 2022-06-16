using AutoMapper;
using KanBan.Models.DTOs;
using KanBan.Models.DTOs.CardDTO;
using KanBan.Models.DTOs.SprintDTO;
using KanBan.Models.DTOs.UserDTO;
using Projeto;

namespace KanBan.Models.AutoMapper

{
    public class Automapper : Profile
    {
        public Automapper()
        {
            //  Create map User
            CreateMap<CreateUserDTO, User>();
            CreateMap<User, ReadUserDTO>()
            .ForMember(user => user.Cards, opts => opts
                .MapFrom(user => user.Cards.Select
                (c => new { c.Status, c.Estimation, c.SprintId })));
            CreateMap<UpdateUserDTO, User>();

            // Create map Sprint
            CreateMap<CreateSprintDTO, Sprint>();
            CreateMap<Sprint, ReadSprintDTO>()
                .ForMember(sprint => sprint.Cards, opts => opts
                .MapFrom(sprint => sprint.Cards.Select
                (c => new { c.Status, c.Estimation, c.UserId })));

            CreateMap<UpdateSprintDTO, Sprint>();

            // Create map Card
            CreateMap<CreateCardDTO, Card>();
            CreateMap<Card, ReadCardDTO>();
            CreateMap<UpdateCardDTO, Card>();


        }

    }
}
