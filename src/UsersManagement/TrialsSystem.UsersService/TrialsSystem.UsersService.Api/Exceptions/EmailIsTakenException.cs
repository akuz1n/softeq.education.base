namespace TrialsSystem.UsersService.Api.Exceptions
{
    public class EmailIsTakenException : Exception
    {
        public string Email { get; }

        public EmailIsTakenException(string email)
        {
            Email = email;
        }
    }
}
