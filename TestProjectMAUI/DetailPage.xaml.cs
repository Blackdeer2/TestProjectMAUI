using TestProjectMAUI.ViewModel;

namespace TestProjectMAUI;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}