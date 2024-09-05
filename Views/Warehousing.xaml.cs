using sucafina.Viewmodels;

namespace sucafina.Views;

public partial class Warehousing : ContentPage
{
    private readonly Mainviewmodel viewmodel;

    public Warehousing(Mainviewmodel viewmodel)
    {
        this.viewmodel = viewmodel;
        BindingContext = viewmodel;
        InitializeComponent();
    }
}