using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;

namespace TrialsSystem.UsersService.Api.Application.Device.Commands
{
    public class UpdateDeviceCommand : IRequest<UpdateDeviceResponse>
    {
        public UpdateDeviceCommand(string id,
            string serialNumber,
            string model,
            string typeId,
            string firmwareVersion)
        {
            Id = id;
            SerialNumber = serialNumber;
            Model = model;
            TypeId = typeId;
            FirmwareVersion = firmwareVersion;
        }

        public string Id { get; }

        public string SerialNumber { get; }

        public string Model { get; }

        public string TypeId { get; }

        public string FirmwareVersion { get; }


    }
}
