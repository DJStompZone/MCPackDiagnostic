
namespace MCDiagnostics
{
	partial class PacksForms
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CompatibilityCheckerTab = new System.Windows.Forms.TabPage();
			this.PackInfosTab = new System.Windows.Forms.TabPage();
			this.ValidatorTab = new System.Windows.Forms.TabPage();
			this.PacksTabView = new System.Windows.Forms.TabControl();
			this.listView1 = new System.Windows.Forms.ListView();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.PacksTabView.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.PacksTabView);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 429);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 447);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(902, 173);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Logger";
			// 
			// CompatibilityCheckerTab
			// 
			this.CompatibilityCheckerTab.Location = new System.Drawing.Point(4, 22);
			this.CompatibilityCheckerTab.Name = "CompatibilityCheckerTab";
			this.CompatibilityCheckerTab.Size = new System.Drawing.Size(895, 397);
			this.CompatibilityCheckerTab.TabIndex = 3;
			this.CompatibilityCheckerTab.Text = "Compatibility checker";
			this.CompatibilityCheckerTab.UseVisualStyleBackColor = true;
			// 
			// PackInfosTab
			// 
			this.PackInfosTab.Location = new System.Drawing.Point(4, 22);
			this.PackInfosTab.Name = "PackInfosTab";
			this.PackInfosTab.Padding = new System.Windows.Forms.Padding(3);
			this.PackInfosTab.Size = new System.Drawing.Size(895, 397);
			this.PackInfosTab.TabIndex = 1;
			this.PackInfosTab.Text = "Pack infos";
			this.PackInfosTab.UseVisualStyleBackColor = true;
			// 
			// ValidatorTab
			// 
			this.ValidatorTab.Location = new System.Drawing.Point(4, 22);
			this.ValidatorTab.Name = "ValidatorTab";
			this.ValidatorTab.Padding = new System.Windows.Forms.Padding(3);
			this.ValidatorTab.Size = new System.Drawing.Size(895, 397);
			this.ValidatorTab.TabIndex = 0;
			this.ValidatorTab.Text = "Validator";
			this.ValidatorTab.UseVisualStyleBackColor = true;
			// 
			// PacksTabView
			// 
			this.PacksTabView.Controls.Add(this.ValidatorTab);
			this.PacksTabView.Controls.Add(this.PackInfosTab);
			this.PacksTabView.Controls.Add(this.CompatibilityCheckerTab);
			this.PacksTabView.Location = new System.Drawing.Point(3, 3);
			this.PacksTabView.Name = "PacksTabView";
			this.PacksTabView.SelectedIndex = 0;
			this.PacksTabView.Size = new System.Drawing.Size(903, 423);
			this.PacksTabView.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(7, 19);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(889, 148);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 632);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Form1";
			this.Text = "MCPackDiagnostic";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.PacksTabView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TabControl PacksTabView;
		private System.Windows.Forms.TabPage ValidatorTab;
		private System.Windows.Forms.TabPage PackInfosTab;
		private System.Windows.Forms.TabPage CompatibilityCheckerTab;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView listView1;
	}
}

