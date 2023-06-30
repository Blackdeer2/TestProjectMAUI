using TestProjectMAUI.ViewModel;

namespace TestProjectMAUI;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

