namespace VakkenOefening.Views;

public partial class OverzichtVakkenGrid : ContentPage
{
	public OverzichtVakkenGrid()
	{
		InitializeComponent();
	}

    private void GoToCourseBiologie(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VakBiologie());
    }

    private void GoToCourseFrans(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VakFrans());
    }
    private void GoToCourseGeschiedenis(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VakGeschiedenis());
    }

    private void GoToCourseNederlands(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VakNederlands());
    }

    private void GoToCourseWiskunde(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VakWiskunde());
    }
}