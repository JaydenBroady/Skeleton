using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsProduct
        clsProduct AProduct = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.Availability);

        //create new instance of clsProduct
        clsProduct AProduct2 = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.ProductId);

        //create new instance of clsProduct
        clsProduct AProduct3 = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.Price);

        //create new instance of clsProduct
        clsProduct AProduct4 = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.Name);

        //create new instance of clsProduct
        clsProduct AProduct5 = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.Description);

        //create new instance of clsProduct
        clsProduct AProduct6 = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.ScentType);

        //create new instance of clsProduct
        clsProduct AProduct7 = new clsProduct();
        //get data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the availability
        Response.Write(AProduct.Occasion);


    }
}