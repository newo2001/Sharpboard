namespace Sharpboard.Forms {
	partial class FormExport {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.buttonExportTextFile = new System.Windows.Forms.Button();
			this.buttonExportBeatmap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonExportTextFile
			// 
			this.buttonExportTextFile.Location = new System.Drawing.Point(12, 12);
			this.buttonExportTextFile.Name = "buttonExportTextFile";
			this.buttonExportTextFile.Size = new System.Drawing.Size(122, 41);
			this.buttonExportTextFile.TabIndex = 16;
			this.buttonExportTextFile.Text = "Export to text file";
			this.buttonExportTextFile.UseVisualStyleBackColor = true;
			this.buttonExportTextFile.Click += new System.EventHandler(this.buttonExportTextFile_Click);
			// 
			// buttonExportBeatmap
			// 
			this.buttonExportBeatmap.Location = new System.Drawing.Point(12, 59);
			this.buttonExportBeatmap.Name = "buttonExportBeatmap";
			this.buttonExportBeatmap.Size = new System.Drawing.Size(122, 41);
			this.buttonExportBeatmap.TabIndex = 17;
			this.buttonExportBeatmap.Text = "Export to beatmap file";
			this.buttonExportBeatmap.UseVisualStyleBackColor = true;
			this.buttonExportBeatmap.Click += new System.EventHandler(this.buttonExportBeatmap_Click);
			// 
			// FormExport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonExportBeatmap);
			this.Controls.Add(this.buttonExportTextFile);
			this.Name = "FormExport";
			this.Text = "FormExport";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExportTextFile;
		private System.Windows.Forms.Button buttonExportBeatmap;
	}
}