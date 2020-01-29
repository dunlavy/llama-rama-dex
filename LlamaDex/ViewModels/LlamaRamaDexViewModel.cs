using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;

using LlamaRamaDex.DataAccess;
using LlamaRamaDex.Models.Interfaces;

namespace LlamaRamaDex.ViewModels {
	public class LlamaRamaDexViewModel:INotifyPropertyChanged {
		private ILlamaRepository _llamaRepository;

		public LlamaRamaDexViewModel(ILlamaRepository llamaDataRepository) {
			_llamaRepository = llamaDataRepository;
			FetchLlamas();
		}

		private ILlama _selectedLlama;
		public ILlama SelectedLlama {
			get => _selectedLlama;
			set {
				_selectedLlama = value;
				_raisePropertyChanged(nameof(SelectedLlama));
				_makeLlamaScream();
			}
		}

		private IEnumerable<ILlama> _llamas;
		public IEnumerable<ILlama> Llamas {
			get => _llamas;
			set {
				_llamas = value;
				_raisePropertyChanged(nameof(Llamas));
			}
		}

		public string RepositoryType => _llamaRepository?.ToString();

		public void FetchLlamas() => Llamas = _llamaRepository?.FetchLlamas();

		public event PropertyChangedEventHandler PropertyChanged;
		private void _raisePropertyChanged([CallerMemberName] string propertyName = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		private void _makeLlamaScream() => new SoundPlayer(Path.Combine("WAV", "GoatScream.wav")).Play();
	}
}
