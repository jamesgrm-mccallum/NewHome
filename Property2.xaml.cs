namespace NewHome;
using Microsoft.Maui.Controls;

public partial class Property2 : ContentPage
{

    public Property2()
    {
        InitializeComponent();
    }

    private void OnMessage(object sender, EventArgs e)
    {
        MessageBtn.Text = "";

    }

}