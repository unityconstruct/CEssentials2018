using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProtoService
{
    /// <summary>
    /// Summary description for TemperatureConverter
    /// </summary>
    [WebService(Namespace = "http://www.unityconstruct.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureConverter : System.Web.Services.WebService
    {
        // annotation for EXPOSING method to the outside world
        [WebMethod]
        public double ConvertFahernheitToCelsius(double Farhenheit)
        {
            double Celsius = (((Farhenheit - 32) * 5) / 9);
            return Celsius;
        }
        [WebMethod]
        public double ConvertCelsiusToFahernheit(double Celsius)
        {
            double Farhenheit = (32 + ((9 * Celsius) / 5));
            return Farhenheit;
        }
    }
}
