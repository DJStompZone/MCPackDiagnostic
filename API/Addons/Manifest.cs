using MCDiagnostics.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MCDiagnostics.API.Addons
{
	public class Manifest
	{
		[JsonProperty("format_version")]
		private int? _formatVersion;
		public int? FormatVersion
		{
			get
			{
				if (_formatVersion == null)
				{
					return 2;
				}
				else
				{
					return _formatVersion;
				}
			}
			set { _formatVersion = value; }
		}

		// Null -> Invalid pack
		[JsonProperty("header")]
		public PackHeader Header { get; set; }

		// Null -> Invalid pack
		[JsonProperty("modules")]
		public List<PackModule> Modules { get; set; }

		// Not required
		[JsonProperty("subpacks")]
		public List<PackSubpack> Subpacks { get; set; }

		// Null -> Does not affect
		[JsonProperty("dependencies")]
		public List<PackDependency> Dependencies { get; set; }

		// Null -> Does not affect
		[JsonProperty("capabilities")]
		public List<string> Capabilities { get; set; }

		// Null -> Does not affect
		[JsonProperty("metadata")]
		public PackMetadata Metadata { get; set; }

		public class PackHeader
		{
			// Null -> Invalid pack
			[JsonProperty("name")]
			public string Name { get; set; }

			// Null -> Invalid pack
			[JsonProperty("description")]
			public string Description { get; set; }

			// Null -> Invalid pack
			[JsonProperty("uuid")]
			public string Uuid { get; set; }

			// Automatically convert null to 0
			[JsonProperty("version")]
			private int?[] _version;
			public int?[] Version
			{
				get { return _version.ReplaceNullBy(0); }
				set { _version = value; }
			}

			// Not required
			[JsonProperty("lock_template_options")]
			public bool LockTemplateOptions { get; set; }

			// Automatically convert null to 0
			[JsonProperty("base_game_version")]
			private int?[] _baseGameVersion;
			public int?[] BaseGameVersion
			{
				get { return _baseGameVersion.ReplaceNullBy(0); }
				set { _baseGameVersion = value; }
			}

			// Automatically convert null to 0
			[JsonProperty("min_engine_version")]
			private int?[] _minEngineVersion;
			public int?[] MinEngineVersion
			{
				get { return _minEngineVersion.ReplaceNullBy(0); }
				set { _minEngineVersion = value; }
			}

			// Convert null to 0
			[JsonProperty("vanilla")]
			private int?[] _vanilla;
			public int?[] Vanilla
			{
				get { return _vanilla.ReplaceNullBy(0); }
				set { _vanilla = value; }
			}
		}

		public class PackModule
		{
			// Null -> Invalid module
			[JsonProperty("uuid")]
			public string Uuid { get; set; }

			// Null -> Warning
			[JsonProperty("description")]
			public string Description { get; set; }

			// Null -> Invalid module
			[JsonProperty("type")]
			public string Type { get; set; }

			// Convert null to 0
			[JsonProperty("version")]
			private int?[] _version;
			public int?[] Version
			{
				get { return _version.ReplaceNullBy(0); }
				set { _version = value; }
			}
		}

		public class PackSubpack
		{
			// Null -> Invalid subpack
			[JsonProperty("folder_name")]
			public string FolderName { get; set; }

			// Null -> Invalid subpack
			[JsonProperty("name")]
			public string Name { get; set; }

			// Null -> Invalid pack for now (next warning)
			[JsonProperty("memory_tier")]
			public int? MemoryTier { get; set; }
		}

		public class PackDependency
		{
			// Null -> Invalid dependency
			[JsonProperty("uuid")]
			public string Uuid { get; set; }

			// Convert null to 0
			[JsonProperty("version")]
			private int?[] _version;
			public int?[] Version
			{
				get { return _version.ReplaceNullBy(0); }
				set { _version = value; }
			}
		}

		public class PackMetadata
		{
			// Null -> Does not affect
			[JsonProperty("authors")]
			public List<string> Authors { get; set; }

			// Null -> Does not affect
			[JsonProperty("licence")]
			public string Licence { get; set; }

			// Null -> Does not affect
			[JsonProperty("url")]
			public string Url { get; set; }
		}

		/// <summary>
		/// Parse manifest.json.
		/// </summary>
		/// <param name="manifest">The manifest file to parse.</param>
		/// <returns>Returns the object of manifest.json.</returns>
		public static Manifest DeserializeManifest(string manifest)
		{
			if (manifest != null)
			{
				JsonSerializerSettings settings = new JsonSerializerSettings()
				{
					ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
					DefaultValueHandling = DefaultValueHandling.Ignore,
					MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
					NullValueHandling = NullValueHandling.Ignore,
					CheckAdditionalContent = false,
					Error = (sender, args) => { args.ErrorContext.Handled = true; }
				};
				return JsonConvert.DeserializeObject<Manifest>(manifest, settings);
			}
			return null;
		}
	}
}