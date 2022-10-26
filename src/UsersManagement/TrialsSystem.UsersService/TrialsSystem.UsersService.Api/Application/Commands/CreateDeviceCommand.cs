﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;

namespace TrialsSystem.UsersService.Api.Application.Commands
{
    public class CreateDeviceCommand : IRequest<CreateDeviceResponse>
    {
        public CreateDeviceCommand(string serialNumber,
            string model,
            string typeId,
            string firmwareVersion)
        {
            SerialNumber = serialNumber;
            Model = model;
            TypeId = typeId;
            FirmwareVersion = firmwareVersion;
        }

        public string SerialNumber { get; set; }

        public string Model { get; set; }

        public string TypeId { get; set; }

        public string FirmwareVersion { get; set; }


    }
}
