using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProtoClient
{
    public partial class WebServiceAggregator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //reference to the webservice
            TemperatureConverterService.TemperatureConverterSoapClient client = new TemperatureConverterService.TemperatureConverterSoapClient();

            // cast the Text input to double
            double dblTemp = Double.Parse(txtTemperatureInput.Text);
            // run the ws call
            double dblResult = client.ConvertFahernheitToCelsius(dblTemp);

            //update the UI with the result
            lblResult.Text = "" + dblResult;
        }
    }
}