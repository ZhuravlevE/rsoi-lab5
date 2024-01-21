using System.Runtime.Serialization;

namespace Gateway.DTO
{
    [DataContract]
    public class AuthData
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        public AuthData(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}
