namespace PartyInvites.Models
{
    public class ErrorViewModel
    {
        //Property
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}