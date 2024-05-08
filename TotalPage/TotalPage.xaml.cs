namespace tdmpw_2p_ex_77344;

using System;
using Microsoft.Maui.Controls;

public partial class TotalPage : ContentPage
{
	public TotalPage()
	{
		InitializeComponent();
	}

        int noProducts = 1;

        private void AddProduct(object sender, EventArgs e) {
            noProducts += 1;
            int productPrice = 0;
            if (ProductName.Text == "Frapuccino") {
                productPrice = 38;
            } else if (ProductName.Text == "Brownie") {
                productPrice = 50;
            } else if (ProductName.Text == "Té") {
                productPrice = 25;
            }

            ProductTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            BigTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            LabelProductQuantity.Text = "x " + noProducts;
        }

        private void RemoveProduct(object sender, EventArgs e) {
            if (noProducts == 1) { return; }
            noProducts -= 1;
            int productPrice = 0;
            if (ProductName.Text == "Frapuccino") {
                productPrice = 38;
            } else if (ProductName.Text == "Brownie") {
                productPrice = 50;
            } else if (ProductName.Text == "Té") {
                productPrice = 25;
            }

            ProductTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            BigTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            LabelProductQuantity.Text = "x " + noProducts;
        }

        private void ChangeProductFrapuccino(object sender, EventArgs e) {
            noProducts = 1;

            ProductImage.Source = ImageSource.FromFile("frapuccino.png");
            ProductName.Text = "Frapuccino";

            int productPrice = 0;
            if (ProductName.Text == "Frapuccino") {
                productPrice = 38;
            } else if (ProductName.Text == "Brownie") {
                productPrice = 50;
            } else if (ProductName.Text == "Té") {
                productPrice = 25;
            }

            ProductTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            BigTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            LabelProductQuantity.Text = "x " + noProducts;
        }

        private void ChangeProductBrownie(object sender, EventArgs e) {
            noProducts = 1;

            ProductImage.Source = ImageSource.FromFile("brownie.jpg");
            ProductName.Text = "Brownie";

            int productPrice = 0;
            if (ProductName.Text == "Frapuccino") {
                productPrice = 38;
            } else if (ProductName.Text == "Brownie") {
                productPrice = 50;
            } else if (ProductName.Text == "Té") {
                productPrice = 25;
            }

            ProductTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            BigTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            LabelProductQuantity.Text = "x " + noProducts;
        }

        private void ChangeProductTea(object sender, EventArgs e) {
            noProducts = 1;

            ProductImage.Source = ImageSource.FromFile("tea.png");
            ProductName.Text = "Té";

            int productPrice = 0;
            if (ProductName.Text == "Frapuccino") {
                productPrice = 38;
            } else if (ProductName.Text == "Brownie") {
                productPrice = 50;
            } else if (ProductName.Text == "Té") {
                productPrice = 25;
            }

            ProductTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            BigTotal.Text = "Total: $ " + (noProducts * productPrice) + ".00";
            LabelProductQuantity.Text = "x " + noProducts;
        }
}
