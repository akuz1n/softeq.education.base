﻿using TrialsSystem.UsersService.Infrastructure.Models.BaseDTO;

namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class GetDeviceResponse
    {
        public string Id { get; set; }

        public string SerialNumber { get; set; }

        public string Model { get; set; }

        public IdNameDto Type { get; set; }

        public string FirmwareVersion { get; set; }

    }
}
