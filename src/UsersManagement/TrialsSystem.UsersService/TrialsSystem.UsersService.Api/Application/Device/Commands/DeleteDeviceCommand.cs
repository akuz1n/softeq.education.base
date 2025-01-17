﻿using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Device.Commands
{
    public class DeleteDeviceCommand : IRequest
    {
        public DeleteDeviceCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }

    }
}
