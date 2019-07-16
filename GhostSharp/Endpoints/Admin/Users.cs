using System.Linq;
using GhostSharp.Entities;
using RestSharp;

namespace GhostSharp
{
    public partial class GhostAdminAPI
    {
            public User GetUser(string email)
            {
                var request = new RestRequest($"users/", Method.GET);
                request.AddQueryParameter("filter", $"email:{email}");
                return Execute<UserResponse>(request)?.Users?.Single();
            }
    }
}
