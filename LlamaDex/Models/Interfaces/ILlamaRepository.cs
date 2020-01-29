using System.Collections.Generic;
using LlamaRamaDex.Models.Interfaces;

namespace LlamaRamaDex.DataAccess {
	public interface ILlamaRepository {
		IEnumerable<ILlama> FetchLlamas();
		string ToString();
	}
}
