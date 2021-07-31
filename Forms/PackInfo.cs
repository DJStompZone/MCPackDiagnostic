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

			PackContainer.Text = manifest.Header.Name;
			// Load there the other labels
		}
	}
}