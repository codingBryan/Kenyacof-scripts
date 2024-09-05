using sucafina.Viewmodels;

namespace sucafina.Views;

public partial class Shipments : ContentPage
{
    private readonly Mainviewmodel viewmodel;

    public Shipments(Mainviewmodel viewmodel)
    {
        this.viewmodel = viewmodel;
        BindingContext = viewmodel;
        InitializeComponent();
        
    }
}