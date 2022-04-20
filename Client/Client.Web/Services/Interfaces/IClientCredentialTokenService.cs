using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Web.Services.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}
