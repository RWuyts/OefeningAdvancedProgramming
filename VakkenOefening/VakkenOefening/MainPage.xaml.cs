using VakkenOefening.Views;

namespace VakkenOefening;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();
    }

    public void GoToOverzichtVakkenStack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenStack());
    }

    public void GoToOverzichtVakkenGrid(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenGrid());
    }
    public void GoToOverzichtVakkenFlex(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenFlex());
    }

}

