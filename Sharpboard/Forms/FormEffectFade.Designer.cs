namespace Sharpboard.Forms {
	partial class FormEffectFade {
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
			this.inputStartTime = new System.Windows.Forms.NumericUpDown();
			this.labelTimestamp = new System.Windows.Forms.Label();
			this.labelCoordinates = new System.Windows.Forms.Label();
			this.inputStartOpacity = new System.Windows.Forms.NumericUpDown();
			this.inputEndOpacity = new System.Windows.Forms.NumericUpDown();
			this.buttonSave = new System.Windows.Forms.Button();
			this.inputEndTime = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.inputStartTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputStartOpacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEndOpacity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEndTime)).BeginInit();
			this.SuspendLayout();
			// 
			// inputStartTime
			// 
			this.inputStartTime.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.inputStartTime.Location = new System.Drawing.Point(93, 12);
			this.inputStartTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.inputStartTime.Name = "inputStartTime";
			this.inputStartTime.Size = new System.Drawing.Size(55, 20);
			this.inputStartTime.TabIndex = 0;
			// 
			// labelTimestamp
			// 
			this.labelTimestamp.AutoSize = true;
			this.labelTimestamp.Location = new System.Drawing.Point(24, 19);
			this.labelTimestamp.Name = "labelTimestamp";
			this.labelTimestamp.Size = new System.Drawing.Size(58, 13);
			this.labelTimestamp.TabIndex = 1;
			this.labelTimestamp.Text = "Timestamp";
			// 
			// labelCoordinates
			// 
			this.labelCoordinates.AutoSize = true;
			this.labelCoordinates.Location = new System.Drawing.Point(24, 42);
			this.labelCoordinates.Name = "labelCoordinates";
			this.labelCoordinates.Size = new System.Drawing.Size(43, 13);
			this.labelCoordinates.TabIndex = 2;
			this.labelCoordinates.Text = "Opacity";
			// 
			// inputStartOpacity
			// 
			this.inputStartOpacity.DecimalPlaces = 2;
			this.inputStartOpacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.inputStartOpacity.Location = new System.Drawing.Point(93, 40);
			this.inputStartOpacity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.inputStartOpacity.Name = "inputStartOpacity";
			this.inputStartOpacity.Size = new System.Drawing.Size(55, 20);
			this.inputStartOpacity.TabIndex = 3;
			// 
			// inputEndOpacity
			// 
			this.inputEndOpacity.DecimalPlaces = 2;
			this.inputEndOpacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.inputEndOpacity.Location = new System.Drawing.Point(158, 40);
			this.inputEndOpacity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.inputEndOpacity.Name = "inputEndOpacity";
			this.inputEndOpacity.Size = new System.Drawing.Size(55, 20);
			this.inputEndOpacity.TabIndex = 4;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(232, 34);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(54, 29);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// inputEndTime
			// 
			this.inputEndTime.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.inputEndTime.Location = new System.Drawing.Point(158, 12);
			this.inputEndTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.inputEndTime.Name = "inputEndTime";
			this.inputEndTime.Size = new System.Drawing.Size(55, 20);
			this.inputEndTime.TabIndex = 8;
			// 
			// FormEffectFade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.inputEndTime);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.inputEndOpacity);
			this.Controls.Add(this.inputStartOpacity);
			this.Controls.Add(this.labelCoordinates);
			this.Controls.Add(this.labelTimestamp);
			this.Controls.Add(this.inputStartTime);
			this.Name = "FormEffectFade";
			this.Text = "Add Fade Effect";
			((System.ComponentModel.ISupportInitialize)(this.inputStartTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputStartOpacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEndOpacity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputEndTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown inputStartTime;
		private System.Windows.Forms.Label labelTimestamp;
		private System.Windows.Forms.Label labelCoordinates;
		private System.Windows.Forms.NumericUpDown inputStartOpacity;
		private System.Windows.Forms.NumericUpDown inputEndOpacity;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.NumericUpDown inputEndTime;
	}
}