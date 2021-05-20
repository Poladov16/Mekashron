using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MekashronProject
{
    public class ServiceLocator
    {
        private static IcutechService.IICUTech SoapSrvc = null;

        public static IcutechService.IICUTech GetSoapService()
        {
            if (SoapSrvc == null)
            {
                SoapSrvc = new IcutechService.ICUTechClient();
            }
            return SoapSrvc;
        }
    }
}