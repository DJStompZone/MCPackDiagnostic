using MCDiagnostics.API.Addons;
using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

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
							foreach (ZipArchiveEntry entry in archive.Entries)
							{
								if (!entry.FullName.EndsWith("/"))
								{
									if (entry.FullName.Contains("manifest.json")) // Load manifest
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

				// Show modules
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