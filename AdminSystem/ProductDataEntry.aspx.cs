using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       


    }

   

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // new instance of clsProduct
        clsProduct AProduct = new clsProduct();
        //capture availability
        AProduct.Availability = Convert.ToInt32(txtAvailability.Text);
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
        Response.Redirect("ProductViewer.aspx");

        // new instance of clsProduct
        clsProduct AProduct2 = new clsProduct();
        //capture availability
        AProduct.ProductId = Convert.ToInt32(txtProductId.Text);
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
        Response.Redirect("ProductViewer.aspx");


        // new instance of clsProduct
        clsProduct AProduct3 = new clsProduct();
        //capture availability
        AProduct.Description = txtDescription.Text;
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
        Response.Redirect("ProductViewer.aspx");

        // new instance of clsProduct
        clsProduct AProduct4 = new clsProduct();
        //capture availability
        AProduct.Occasion = txtOccasion.Text;
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
        Response.Redirect("ProductViewer.aspx");

        // new instance of clsProduct
        clsProduct AProduct5 = new clsProduct();
        //capture availability
        AProduct.Name = txtNameProduct.Text;
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
        Response.Redirect("ProductViewer.aspx");

        // new instance of clsProduct
        clsProduct AProduct6 = new clsProduct();
        //capture availability
        AProduct.ScentType = txtScentType.Text;
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
        Response.Redirect("ProductViewer.aspx");

        // new instance of clsProduct
        clsProduct AProduct7 = new clsProduct();
        //capture availability
        AProduct.Price = Convert.ToInt32(txtPrice.Text);
        // stores the information in the session object
        Session["AProduct"] = AProduct;
        //naviagte to the view page 
       Response.Redirect("ProductViewer.aspx");
    }
}
