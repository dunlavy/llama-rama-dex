using System.Windows.Controls;

using LlamaRamaDex.ViewModels;

namespace LlamaRamaDex.Pages {
	public partial class LlamaRamaDexPage:Page {
		public LlamaRamaDexPage(LlamaRamaDexViewModel viewModel) {
			InitializeComponent();
			DataContext = viewModel;
		}
	}
}
