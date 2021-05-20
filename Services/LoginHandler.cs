using MekashronProject.Interfaces;
using MekashronProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace MekashronProject.Services
{
    public class LoginHandler : ILoginService
    {
        readonly IcutechService.IICUTech _icutTechService;

        public LoginHandler(IcutechService.IICUTech dep)
        {
            _icutTechService = dep;
        }
        public object LoginToSoapService(LoginCredentials crd)
        {
            var request = MapCredentialsToRequest(crd);
            var result = _icutTechService.LoginAsync(request).Result.@return;
            return result;
            //return JsonSerializer.Deserialize<Object>(result);
        }
        IcutechService.LoginRequest MapCredentialsToRequest(LoginCredentials crd)
        {
            return new IcutechService.LoginRequest { Password = crd.Password, UserName = crd.Username, IPs = crd.IPs };
        }
    }
}