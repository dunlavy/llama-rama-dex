using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

using LlamaRamaDex.Models;
using LlamaRamaDex.Models.Interfaces;

namespace LlamaRamaDex.DataAccess {
	public class AnotherLlamaRepository:ILlamaRepository {
		public IEnumerable<ILlama> FetchLlamas() {
			return new ObservableCollection<ILlama>() {
				new Llama("Nasty", Path.Combine("/Graphics", "Nasty.gif")),
				new Llama("Ryeker", Path.Combine("/Graphics", "Ryeker.gif"))
			};
		}

		public override string ToString() => nameof(AnotherLlamaRepository);
	}
}
