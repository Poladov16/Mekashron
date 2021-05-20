using MekashronProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MekashronProject.Interfaces
{
    public interface ILoginService
    {
        object LoginToSoapService(LoginCredentials crd);

    }
}
