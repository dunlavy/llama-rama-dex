using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace LlamaRamaDex {
	public partial class MainWindow:NavigationWindow {
		private Page _compositedLlamaDexPage;

		public MainWindow(Page configuredLlamaPage) => _initializePageComponent(configuredLlamaPage);

		private void _navigate(object sender, RoutedEventArgs e) {
			Hyperlink referringHyperlink = (Hyperlink)sender;

			if (referringHyperlink.Name == nameof(Llama)) {
				// "Llama" was the hyperlink clicked by the user, but now pages are using
				// constructor injection... obviously no longer a parameterless constructor!
				// We reassert some of the XAML functionality here; use navigation service
				// with our injected page!

				NavigationFrame.NavigationService.Navigate(_compositedLlamaDexPage);
			}
		}

		private void _initializePageComponent(Page llamaDexPage) {
			InitializeComponent();
			_compositedLlamaDexPage = llamaDexPage;
			// start to have llama page loaded (done before via XAML declaration)
			NavigationFrame.NavigationService.Navigate(_compositedLlamaDexPage);
		}
	}
}
