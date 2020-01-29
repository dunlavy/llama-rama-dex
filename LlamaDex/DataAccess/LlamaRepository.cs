using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

using LlamaRamaDex.Models;
using LlamaRamaDex.Models.Interfaces;

namespace LlamaRamaDex.DataAccess {
	public class LlamaRepository:ILlamaRepository {
		public IEnumerable<ILlama> FetchLlamas() {
			return new ObservableCollection<ILlama>() {
				new Llama("Fabulous", Path.Combine("/Graphics", "Fabulous.gif")),
				new Llama("Sassy", Path.Combine("/Graphics", "Sassy.gif"))
			};
		}

		public override string ToString() => nameof(LlamaRepository);
	}
}
