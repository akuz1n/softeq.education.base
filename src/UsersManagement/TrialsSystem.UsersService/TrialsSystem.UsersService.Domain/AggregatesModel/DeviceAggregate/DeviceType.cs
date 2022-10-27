using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    internal class DeviceType : Entity
    {
        public DeviceType(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
