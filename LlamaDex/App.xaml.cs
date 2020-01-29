using System.Configuration;
using System.Windows;
using System.Windows.Controls;

using LlamaRamaDex.DataAccess;
using LlamaRamaDex.Pages;
using LlamaRamaDex.ViewModels;

namespace LlamaRamaDex {
	public partial class App:Application {
		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);

			_composeObjects();

			// we're doing this instead of WPF XAML like it did before
			Current.MainWindow.Show();
		}

		private void _composeObjects() {
			ILlamaRepository llamaRepository = _getLlamaRepositoryByConfig();
			LlamaRamaDexViewModel viewModel  = new LlamaRamaDexViewModel(llamaRepository);

			// Exercise:  We can even abstract "page" out so that different pages can be loaded depending
			// on user options; for now, we only have the one, "LlamaRamaDexPage," so make that the default
			Page llamaRamaDexDefaultPage = new LlamaRamaDexPage(viewModel);
			MainWindow window            = new MainWindow(llamaRamaDexDefaultPage);

			// finally, set our application's window to our window constructed from above
			Current.MainWindow = window;
		}

		private static ILlamaRepository _getLlamaRepositoryByConfig() {
			string repositorySettingValue = ConfigurationManager.AppSettings.Get("Repository").ToLower();

			switch (repositorySettingValue) {
				case "llamarepository":
					return new LlamaRepository();
				case "otherllamarepository":
					return new AnotherLlamaRepository();
				default: return null;
			}
		}
	}
}
