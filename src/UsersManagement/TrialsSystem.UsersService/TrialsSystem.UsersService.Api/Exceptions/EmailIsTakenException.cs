namespace TrialsSystem.UsersService.Api.Exceptions
{
    public class EmailIsTakenException : Exception
    {
        public string Email { get; set; }

        public EmailIsTakenException(string email)
        {
            Email = email;
        }
    }
}
