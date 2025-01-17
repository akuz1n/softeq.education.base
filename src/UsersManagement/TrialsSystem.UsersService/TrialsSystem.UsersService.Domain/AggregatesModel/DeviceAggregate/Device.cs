﻿using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    internal class Device : Entity
    {
        public Device(string serialNumber, string model, DeviceType type, string firmwareVersion)
        {
            SerialNumber = serialNumber;
            Model = model;
            Type = type;
            FirmwareVersion = firmwareVersion;
        }

        public string SerialNumber { get; private set; }

        public string Model { get; private set; }

        public DeviceType Type { get; private set; }

        public string FirmwareVersion { get; private set; }
    }
}
