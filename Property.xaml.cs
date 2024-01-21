namespace NewHome;
using Microsoft.Maui.Controls;

public partial class Property : ContentPage
{

    public Property()
    {
        InitializeComponent();
    }

    private void OnMessage(object sender, EventArgs e)
    {
        MessageBtn.Text = "";

    }

}