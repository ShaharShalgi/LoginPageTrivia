namespace LoginPage.Views;
using ViewModels;

public partial class BestScoresPageView : ContentPage
{
	public BestScoresPageView()
	{
		InitializeComponent();
        this.BindingContext = new BestScoresPageViewModel();
    }
}