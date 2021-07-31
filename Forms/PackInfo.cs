using MCDiagnostics.API.Addons;
using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Drawing;

namespace MCDiagnostics.Forms
{
	public partial class PackInfo : Form
	{
		public PackInfo()
		{
			InitializeComponent();
		}

		private void PackInfo_Load(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Minecraft pack files (*.mcpack)|*.mcpack|Minecraft World (*.mcworld)|*.mcworld";
			openFileDialog.Multiselect = false;
			openFileDialog.RestoreDirectory = true;

			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK) // A file was selected
			{
				if (File.Exists(openFileDialog.FileName))
				{
					using (Stream archiveStream = File.OpenRead(openFileDialog.FileName))
					{
						using (ZipArchive archive = new ZipArchive(archiveStream))
						{
							// Fetch manifest and fill infos
							ZipArchiveEntry entry = GetFileEntryFromName(archive, "manifest.json");
							if (entry != null)
							{
								using (StreamReader reader = new StreamReader(entry.Open()))
								{
									Manifest manifest = Manifest.DeserializeManifest(reader.ReadToEnd());
									if (manifest != null)
									{
										LoadPackFromManifest(manifest);
									}
								}
							}

							// Fetch pack icon
							ZipArchiveEntry pack_icon = GetFileEntryFromName(archive, "pack_icon.png");
							if (pack_icon != null)
							{
								using (Stream packIconEntryStream= pack_icon.Open())
								{
    								PackIcon.Image = GetImageFromStream(packIconEntryStream);
								}

							}

						}
					}
				}
			}
			else
			{
				MessageBox.Show($"The specified file doesn't exist. (Path: {openFileDialog.FileName})");
			}
		}

		private ZipArchiveEntry GetFileEntryFromName(ZipArchive source, string name)
		{
			foreach (ZipArchiveEntry entry in source.Entries)
			{
				if (!entry.FullName.EndsWith("/"))
				{
					if (entry.FullName.Contains(name)) // Load manifest
					{
						return entry;
					}
				}
			}
			return null;
		}

		private Image GetImageFromStream(Stream stream) {	return Image.FromStream(stream);	}

		private void LoadPackFromManifest(Manifest manifest)
		{
			if (manifest != null)
			{
				// Set pack description
				PackDescriptionLabel.Text = manifest.Header.Description;

				// Show pack type
				PackContainer.Text = manifest.Header.Name;

				PackTypeLabel.Text = manifest.Modules[0].Type;

				// Show pack manifest format version
				if (manifest.FormatVersion != null)
				{
					FormatVersionLabel.Text = manifest.FormatVersion.ToString();
				}
				else
				{
					FormatVersionLabel.Text = "0";
				}

				// Show pack UUID
				if (string.IsNullOrWhiteSpace(manifest.Header.Uuid))
				{
					UUIDLabel.Text = "00000000-0000-0000-0000-000000000000"; // Default empty ID
				}
				else
				{
					UUIDLabel.Text = manifest.Header.Uuid; // Pack manifest ID
				}

				// Show pack lock template options
				if (manifest.Header.LockTemplateOptions == true)
				{
					LockTemplateOptionsLabel.Text = "Yes";
				}
				else
				{
					LockTemplateOptionsLabel.Text = "No";
				}

				// Show pack version
				VersionLabel.Text = string.Join(".", manifest.Header.Version);

				// Show minimum engine version
				MinEngineVersionLabel.Text = string.Join(".", manifest.Header.MinEngineVersion);

				// Show base game version
				BaseGameVersionLabel.Text = string.Join(".", manifest.Header.BaseGameVersion);

				// Show game vanilla version
				VanillaLabel.Text = string.Join(".", manifest.Header.Vanilla);

				// Show dependencies
				if (manifest.Dependencies != null && manifest.Dependencies.Count > 0)
				{
					DependenciesLabel.Text = manifest.Dependencies.Count.ToString();
				}
				else
				{
					DependenciesLabel.Text = "No";
				}

				if (manifest.Modules != null && manifest.Modules.Count > 0)
				{
					ModulesLabel.Text = manifest.Modules.Count.ToString();
				}
				else
				{
					ModulesLabel.Text = "No";
				}
			}
		}
	}
}