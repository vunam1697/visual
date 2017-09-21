using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product : System.Web.UI.Page
{
    protected void Page_PreInit(object seder, EventArgs e)
    {
       Image img = (Image)Master.FindControl("Image1");
        img.ImageUrl = "~/Image/Untitled1.jpg";

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Master.ButtonSearch += ButtonSearch_Click;
    }
    void ButtonSearch_Click(object seder,EventArgs e)
    {
        
    }
}