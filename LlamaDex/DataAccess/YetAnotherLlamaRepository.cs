using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

using LlamaRamaDex.Models;
using LlamaRamaDex.Models.Interfaces;

namespace LlamaRamaDex.DataAccess {
	public class YetAnotherLlamaRepository:ILlamaRepository {
		public IEnumerable<ILlama> FetchLlamas() {
			return new ObservableCollection<ILlama>() {
				new Llama("Ryeker", Path.Combine("/Graphics", "Ryeker.gif")),
				new Llama("Fabulous", Path.Combine("/Graphics", "Fabulous.gif"))
			};
		}

		public override string ToString() => nameof(YetAnotherLlamaRepository);
	}
}
