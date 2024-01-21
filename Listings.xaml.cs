namespace NewHome;

public partial class Listings : ContentPage
{
    public Listings()
    {
        InitializeComponent();
    }
    void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
    }
    private void SendToProperty(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Property() { BackgroundColor = BackgroundColor });
    }

    private void SendToProperty2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Property2() { BackgroundColor = BackgroundColor });
    }

    private void SendToProperty3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Property3() { BackgroundColor = BackgroundColor });
    }
}