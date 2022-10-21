﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class UserQuery : IRequest<GetUsersResponse>
    {
        public UserQuery(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}
