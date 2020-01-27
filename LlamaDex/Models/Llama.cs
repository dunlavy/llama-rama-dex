using LlamaRamaDex.Models.Interfaces;

namespace LlamaRamaDex.Models {
	public class Llama:ILlama {
		public Llama(string name, string photoUrl) {
			Name = name;
			PhotoUrl = photoUrl;
		}

		public string Name { get; set; }
		public string PhotoUrl { get; set; }
	}
}
