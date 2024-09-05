using sucafina.Viewmodels;

namespace sucafina.Views;

public partial class Clients : ContentPage
{
    private readonly Mainviewmodel viewmodel;

    public Clients(Mainviewmodel viewmodel)
	{
		this.viewmodel = viewmodel;
		BindingContext = viewmodel;
		InitializeComponent();
	}
}