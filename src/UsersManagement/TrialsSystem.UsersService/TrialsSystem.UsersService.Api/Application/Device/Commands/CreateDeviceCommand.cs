using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;

namespace TrialsSystem.UsersService.Api.Application.Device.Commands
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

        public string SerialNumber { get; }

        public string Model { get; }

        public string TypeId { get; }

        public string FirmwareVersion { get; }


    }
}
