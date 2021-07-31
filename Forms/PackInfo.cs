using MCDiagnostics.API.Addons;
using System;
using System.Windows.Forms;

namespace MCDiagnostics.Forms
{
	public partial class PackInfo : Form
	{
		public PackInfo()
		{
			InitializeComponent();
		}

		// DONT EXECUTE THE PROGRAM, the variable of manifest are not set so it'll crash with Null exception

		/* PackContainer
		 * PackTypeLabel
		 * FormatVersionLabel
		 * UUIDLabel
		 * LockTemplateOptionsLabel
		 * VersionLabel
		 * MinimumEngineVersionLabel
		 * BaseGameVersionLabel
		 * VanillaLabel
		 * DependenciesLabel
		 * ModulesLabel
		 */

		private void PackInfo_Load(object sender, EventArgs e)
		{
			Manifest manifest = new Manifest();

			PackContainer.Text = manifest.Header.Name;
			PackTypeLabel.Text = manifest.Modules[0].Type;
			FormatVersionLabel.Text = manifest.FormatVersion;
			UUIDLabel.Text = manifest.PackHeader.Uuid;
			LockTemplateOptionsLabel.Text = manifest.LockTemplateOptions;
			VersionLabel.Text = manifest.PackHeader.Version;
			MinimumEngineVersionLabel.Text = manifest.PackHeader.MinEngineVersion;
			BaseGameVersionLabel.Text = manifest.BaseGameVersion;
			VanillaLabel.Text = manifest.Vanilla;
			DependenciesLabel.Text = manifest.Dependencies;
			ModulesLabel.Text = manifest.Modules;

			// Load there the other labels
		}
	}
}
