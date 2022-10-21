using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    internal class Device : Entity
    {
        public string Id { get; set; }

        public string SerialNumber { get; set; }

        public string Model { get; set; }

        public DeviceType Type { get; set; }

        public string FirmwareVersion { get; set; }
    }
}
