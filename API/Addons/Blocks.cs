using Newtonsoft.Json;

namespace MCDiagnostics.API.Addons
{
	public class Blocks
	{
		/// <summary>
		/// Parse blocks.json file.
		/// </summary>
		/// <param name="blocksJSON">The blocks.json file.</param>
		/// <returns>Returns the object of blocks.json.</returns>
		public static Blocks DeserializeBlocks(string blocks)
		{
			JsonSerializerSettings settings = new JsonSerializerSettings()
			{
				ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
				DefaultValueHandling = DefaultValueHandling.Ignore,
				MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore,
				CheckAdditionalContent = false,
				Error = (sender, args) => { args.ErrorContext.Handled = true; }
			};
			return JsonConvert.DeserializeObject<Blocks>(blocks, settings);
		}
	}
}