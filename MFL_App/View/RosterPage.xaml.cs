using MFL_App.ViewModel;

namespace MFL_App.View;

public partial class RosterPage : ContentPage
{

	public RosterPage(RosterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}