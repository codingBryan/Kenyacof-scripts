using sucafina.Viewmodels;

namespace sucafina.Views;

public partial class Reports : ContentPage
{
    private readonly Mainviewmodel viewmodel;

    public Reports(Mainviewmodel viewmodel)
	{
		this.viewmodel = viewmodel;
		BindingContext = viewmodel;
		InitializeComponent();
	}
}