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
        // Create a new instance of clsProduct
        clsProduct AProduct = new clsProduct();

        // Capture values from the textboxes
        string Availability = txtAvailability.Text;
        string ProductId = txtProductId.Text;
        string Description = txtDescription.Text;
        string Occasion = txtOccasion.Text;
        string Name = txtNameProduct.Text;
        string ScentType = txtScentType.Text;
        string Price = txtPrice.Text;

        // Variable to store any error messages
        string Error = "";

        // Validate the data (assuming a valid method exists)
        //Error = AProduct.Valid(Availability, ProductId, Description, Occasion, Name, ScentType, Price);

        if (Error == "")
        {
            // Capture the values into the clsProduct object
            AProduct.Availability = Convert.ToInt32(Availability);
            AProduct.ProductId = Convert.ToInt32(ProductId);
            AProduct.Description = Description;
            AProduct.Occasion = Occasion;
            AProduct.Name = Name;
            AProduct.ScentType = ScentType;
            AProduct.Price = Convert.ToInt32(Price);

            // Store the AProduct object in the session
            Session["AProduct"] = AProduct;

            // Navigate to the view page
            Response.Redirect("ProductViewer.aspx");
        }
        else
        {
            // Handle the error (e.g., display error message)
            lblError.Text = Error;
        }
    }
}



