using MauiConverter.MVVM.ViewModels;

namespace MauiConverter.MVVM.Views;

public partial class ConversionView : ContentPage
{
	public ConversionView()
	{
		InitializeComponent();
		//BindingContext = new ConversionViewModel();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var viewModel =
             (ConversionViewModel)BindingContext;
        viewModel.Convert();
    }
}