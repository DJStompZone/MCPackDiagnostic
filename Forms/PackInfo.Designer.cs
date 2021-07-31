
namespace MCDiagnostics.Forms
{
	partial class PackInfo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.GeneralContainer = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ModulesLabel = new System.Windows.Forms.Label();
			this.DependenciesLabel = new System.Windows.Forms.Label();
			this.VanillaLabel = new System.Windows.Forms.Label();
			this.BaseGameVersionLabel = new System.Windows.Forms.Label();
			this.MinEngineVersionLabel = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.LockTemplateOptionsLabel = new System.Windows.Forms.Label();
			this.UUIDLabel = new System.Windows.Forms.Label();
			this.FormatVersionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.PackTypeLabel = new System.Windows.Forms.Label();
			this.PackContainer = new System.Windows.Forms.GroupBox();
			this.PackDescriptionLabel = new System.Windows.Forms.Label();
			this.PackIcon = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.GeneralContainer.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.PackContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PackIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.GeneralContainer);
			this.groupBox1.Controls.Add(this.PackContainer);
			this.groupBox1.Controls.Add(this.PackIcon);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(539, 581);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pack details";
			// 
			// GeneralContainer
			// 
			this.GeneralContainer.Controls.Add(this.tableLayoutPanel1);
			this.GeneralContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GeneralContainer.Location = new System.Drawing.Point(6, 121);
			this.GeneralContainer.Name = "GeneralContainer";
			this.GeneralContainer.Size = new System.Drawing.Size(527, 223);
			this.GeneralContainer.TabIndex = 4;
			this.GeneralContainer.TabStop = false;
			this.GeneralContainer.Text = "General";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.15534F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.84466F));
			this.tableLayoutPanel1.Controls.Add(this.ModulesLabel, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.DependenciesLabel, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.VanillaLabel, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.BaseGameVersionLabel, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.MinEngineVersionLabel, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.VersionLabel, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.LockTemplateOptionsLabel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.UUIDLabel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.FormatVersionLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.PackTypeLabel, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 198);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ModulesLabel
			// 
			this.ModulesLabel.AutoSize = true;
			this.ModulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ModulesLabel.Location = new System.Drawing.Point(148, 178);
			this.ModulesLabel.Name = "ModulesLabel";
			this.ModulesLabel.Size = new System.Drawing.Size(41, 13);
			this.ModulesLabel.TabIndex = 19;
			this.ModulesLabel.Text = "label20";
			// 
			// DependenciesLabel
			// 
			this.DependenciesLabel.AutoSize = true;
			this.DependenciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DependenciesLabel.Location = new System.Drawing.Point(148, 158);
			this.DependenciesLabel.Name = "DependenciesLabel";
			this.DependenciesLabel.Size = new System.Drawing.Size(41, 13);
			this.DependenciesLabel.TabIndex = 18;
			this.DependenciesLabel.Text = "label19";
			// 
			// VanillaLabel
			// 
			this.VanillaLabel.AutoSize = true;
			this.VanillaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VanillaLabel.Location = new System.Drawing.Point(148, 138);
			this.VanillaLabel.Name = "VanillaLabel";
			this.VanillaLabel.Size = new System.Drawing.Size(41, 13);
			this.VanillaLabel.TabIndex = 17;
			this.VanillaLabel.Text = "label18";
			// 
			// BaseGameVersionLabel
			// 
			this.BaseGameVersionLabel.AutoSize = true;
			this.BaseGameVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BaseGameVersionLabel.Location = new System.Drawing.Point(148, 118);
			this.BaseGameVersionLabel.Name = "BaseGameVersionLabel";
			this.BaseGameVersionLabel.Size = new System.Drawing.Size(41, 13);
			this.BaseGameVersionLabel.TabIndex = 16;
			this.BaseGameVersionLabel.Text = "label17";
			// 
			// MinEngineVersionLabel
			// 
			this.MinEngineVersionLabel.AutoSize = true;
			this.MinEngineVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinEngineVersionLabel.Location = new System.Drawing.Point(148, 98);
			this.MinEngineVersionLabel.Name = "MinEngineVersionLabel";
			this.MinEngineVersionLabel.Size = new System.Drawing.Size(41, 13);
			this.MinEngineVersionLabel.TabIndex = 15;
			this.MinEngineVersionLabel.Text = "label16";
			// 
			// VersionLabel
			// 
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VersionLabel.Location = new System.Drawing.Point(148, 78);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(41, 13);
			this.VersionLabel.TabIndex = 14;
			this.VersionLabel.Text = "label15";
			// 
			// LockTemplateOptionsLabel
			// 
			this.LockTemplateOptionsLabel.AutoSize = true;
			this.LockTemplateOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LockTemplateOptionsLabel.Location = new System.Drawing.Point(148, 58);
			this.LockTemplateOptionsLabel.Name = "LockTemplateOptionsLabel";
			this.LockTemplateOptionsLabel.Size = new System.Drawing.Size(41, 13);
			this.LockTemplateOptionsLabel.TabIndex = 13;
			this.LockTemplateOptionsLabel.Text = "label14";
			// 
			// UUIDLabel
			// 
			this.UUIDLabel.AutoSize = true;
			this.UUIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UUIDLabel.Location = new System.Drawing.Point(148, 38);
			this.UUIDLabel.Name = "UUIDLabel";
			this.UUIDLabel.Size = new System.Drawing.Size(41, 13);
			this.UUIDLabel.TabIndex = 12;
			this.UUIDLabel.Text = "label13";
			// 
			// FormatVersionLabel
			// 
			this.FormatVersionLabel.AutoSize = true;
			this.FormatVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormatVersionLabel.Location = new System.Drawing.Point(148, 19);
			this.FormatVersionLabel.Name = "FormatVersionLabel";
			this.FormatVersionLabel.Size = new System.Drawing.Size(41, 13);
			this.FormatVersionLabel.TabIndex = 11;
			this.FormatVersionLabel.Text = "label12";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pack type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Format version";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "UUID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Lock template options";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Version";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Minimum engine version";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(114, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Base game version";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 138);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Vanilla";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 158);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Dependencies";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 178);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Modules";
			// 
			// PackTypeLabel
			// 
			this.PackTypeLabel.AutoSize = true;
			this.PackTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackTypeLabel.Location = new System.Drawing.Point(148, 0);
			this.PackTypeLabel.Name = "PackTypeLabel";
			this.PackTypeLabel.Size = new System.Drawing.Size(41, 13);
			this.PackTypeLabel.TabIndex = 10;
			this.PackTypeLabel.Text = "label11";
			// 
			// PackContainer
			// 
			this.PackContainer.Controls.Add(this.PackDescriptionLabel);
			this.PackContainer.Location = new System.Drawing.Point(113, 19);
			this.PackContainer.Name = "PackContainer";
			this.PackContainer.Size = new System.Drawing.Size(420, 96);
			this.PackContainer.TabIndex = 3;
			this.PackContainer.TabStop = false;
			this.PackContainer.Text = "Pack name";
			// 
			// PackDescriptionLabel
			// 
			this.PackDescriptionLabel.AutoSize = true;
			this.PackDescriptionLabel.Location = new System.Drawing.Point(6, 16);
			this.PackDescriptionLabel.Name = "PackDescriptionLabel";
			this.PackDescriptionLabel.Size = new System.Drawing.Size(86, 13);
			this.PackDescriptionLabel.TabIndex = 2;
			this.PackDescriptionLabel.Text = "Pack description";
			// 
			// PackIcon
			// 
			this.PackIcon.Location = new System.Drawing.Point(6, 19);
			this.PackIcon.Name = "PackIcon";
			this.PackIcon.Size = new System.Drawing.Size(100, 96);
			this.PackIcon.TabIndex = 0;
			this.PackIcon.TabStop = false;
			// 
			// PackInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 605);
			this.Controls.Add(this.groupBox1);
			this.Name = "PackInfo";
			this.Text = "PackInfo";
			this.Load += new System.EventHandler(this.PackInfo_Load);
			this.groupBox1.ResumeLayout(false);
			this.GeneralContainer.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.PackContainer.ResumeLayout(false);
			this.PackContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PackIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox PackContainer;
		private System.Windows.Forms.Label PackDescriptionLabel;
		private System.Windows.Forms.PictureBox PackIcon;
		private System.Windows.Forms.GroupBox GeneralContainer;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label ModulesLabel;
		private System.Windows.Forms.Label DependenciesLabel;
		private System.Windows.Forms.Label VanillaLabel;
		private System.Windows.Forms.Label BaseGameVersionLabel;
		private System.Windows.Forms.Label MinEngineVersionLabel;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label LockTemplateOptionsLabel;
		private System.Windows.Forms.Label UUIDLabel;
		private System.Windows.Forms.Label FormatVersionLabel;
		private System.Windows.Forms.Label PackTypeLabel;
	}
}