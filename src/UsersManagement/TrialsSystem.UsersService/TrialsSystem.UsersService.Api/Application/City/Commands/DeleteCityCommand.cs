﻿using MediatR;

namespace TrialsSystem.UsersService.Api.Application.City.Commands
{
    public class DeleteCityCommand : IRequest
    {
        public string Id { get; set; }

        public DeleteCityCommand(string id)
        {
            Id = id;
        }
    }
}