using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    internal class DeviceType : Entity
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
