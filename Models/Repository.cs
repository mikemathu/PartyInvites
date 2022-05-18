using System.Collections.Generic;

namespace PartyInvites.Models
{
    public class Repository
    {
        public static class Repository
        {
            private static List<GuestResponse> Responses
            {
                get
                {
                    return Responses;
                }
            }
            public static void AddResponse(GuestResponse response)
            {
                responses.Add(response);
            }
        }
    }
}
