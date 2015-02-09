using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JessesHockeyShop.Models;
using JessesHockeyShop.Logic;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;

namespace JessesHockeyShop
{
  public partial class ShoppingCart : System.Web.UI.Page
  {
      public string CartId { get; set; }
      public ShoppingCartObject ShoppingCart_Object { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        ShoppingCartActions actions = new ShoppingCartActions();
        this.CartId = actions.GetCartId();

        this.ShoppingCart_Object = new ShoppingCartObject(this.CartId);

        if(this.ShoppingCart_Object.sc_CartItemList.Count > 0)
        {
            lblTotal.Text = String.Format("{0:c}", ShoppingCart_Object.getTotal());
        }
        else
        {
            LabelTotalText.Text = "";
            lblTotal.Text = "";
            ShoppingCartTitle.InnerText = "Shopping Cart is Empty";
            UpdateBtn.Visible = false;
            CheckoutImageBtn.Visible = false;
        }
    }

    public List<CartItem> GetShoppingCartItems()
    {
        return this.ShoppingCart_Object.sc_CartItemList;
    }

    public List<CartItem> UpdateCartItems()
    {
      using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
      {
        String cartId = usersShoppingCart.GetCartId();

        ShoppingCartActions.ShoppingCartUpdates[] cartUpdates = new ShoppingCartActions.ShoppingCartUpdates[CartList.Rows.Count];
        for (int i = 0; i < CartList.Rows.Count; i++)
        {
          IOrderedDictionary rowValues = new OrderedDictionary();
          rowValues = GetValues(CartList.Rows[i]);
          cartUpdates[i].ProductId = Convert.ToInt32(rowValues["ProductID"]);

          CheckBox cbRemove = new CheckBox();
          cbRemove = (CheckBox)CartList.Rows[i].FindControl("Remove");
          cartUpdates[i].RemoveItem = cbRemove.Checked;

          TextBox quantityTextBox = new TextBox();
          quantityTextBox = (TextBox)CartList.Rows[i].FindControl("PurchaseQuantity");
          cartUpdates[i].PurchaseQuantity = Convert.ToInt16(quantityTextBox.Text.ToString());
        }
        usersShoppingCart.UpdateShoppingCartDatabase(cartId, cartUpdates);
        CartList.DataBind();
        lblTotal.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());
        return usersShoppingCart.GetCartItems();
      }
    }

    public static IOrderedDictionary GetValues(GridViewRow row)
    {
      IOrderedDictionary values = new OrderedDictionary();
      foreach (DataControlFieldCell cell in row.Cells)
      {
        if (cell.Visible)
        {
          // Extract values from the cell.
          cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
        }
      }
      return values;
    }

    protected void UpdateBtn_Click(object sender, EventArgs e)
    {
      UpdateCartItems();

            //this is commented out so that the quantity box will not update and the test will fail
            //uncomment this out and publish to get the text box to update correctly
      Response.Redirect(Request.RawUrl);
    }

    protected void CheckoutBtn_Click(object sender, ImageClickEventArgs e)
    {
      using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
      {
        Session["payment_amt"] = usersShoppingCart.GetTotal();
      }
      Response.Redirect("https://www.paypal.com/signin/?returnUrl=%2Fcgi-bin%2Fwebscr%3Fcmd%3D_account&country.x=US&locale.x=en_US");
    }
  }
}