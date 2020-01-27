using System.Windows.Controls;

using LlamaRamaDex.ViewModels;

namespace LlamaRamaDex.Pages {
	public partial class LlamaRamaDex:Page {
		public LlamaRamaDex() {
			InitializeComponent();
			DataContext = new LlamaRamaDexViewModel();
		}
	}
}
