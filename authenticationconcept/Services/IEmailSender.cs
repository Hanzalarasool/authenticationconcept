namespace authenticationconcept.Services
{
    public interface IEmailSenders
    {
        Task SendEmailAsync(string email, string subject, string message);
    }


}
