namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos
{
    public class CreateDeviceRequest
    {
        public string SerialNumber { get; set; }

        public string Model { get; set; }

        public string TypeId { get; set; }

        public string FirmwareVersion { get; set; }

    }
}
