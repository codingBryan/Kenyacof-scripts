using sucafina.Viewmodels;

namespace sucafina.Views;

public partial class Dashboard : ContentPage
{
    private readonly Mainviewmodel viewmodel;

    public Dashboard(Mainviewmodel viewmodel)
	{
		this.viewmodel = viewmodel;
		BindingContext = viewmodel;
		InitializeComponent();
	}
}