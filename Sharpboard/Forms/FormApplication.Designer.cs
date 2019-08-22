namespace Sharpboard.Forms {
	partial class FormApplication {
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
			this.buttonAddEffect = new System.Windows.Forms.Button();
			this.containerEffects = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Effects = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonEditEffect = new System.Windows.Forms.Button();
			this.buttonRemoveEffect = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.containerEffects)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddEffect
			// 
			this.buttonAddEffect.Location = new System.Drawing.Point(12, 12);
			this.buttonAddEffect.Name = "buttonAddEffect";
			this.buttonAddEffect.Size = new System.Drawing.Size(78, 34);
			this.buttonAddEffect.TabIndex = 1;
			this.buttonAddEffect.Text = "Add Effect";
			this.buttonAddEffect.UseVisualStyleBackColor = true;
			this.buttonAddEffect.Click += new System.EventHandler(this.buttonAddEffect_Click);
			// 
			// containerEffects
			// 
			this.containerEffects.AllowUserToAddRows = false;
			this.containerEffects.AllowUserToDeleteRows = false;
			this.containerEffects.AllowUserToResizeColumns = false;
			this.containerEffects.AllowUserToResizeRows = false;
			this.containerEffects.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
			this.containerEffects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.containerEffects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.containerEffects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Effects});
			this.containerEffects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.containerEffects.Location = new System.Drawing.Point(183, 12);
			this.containerEffects.Name = "containerEffects";
			this.containerEffects.RowHeadersVisible = false;
			this.containerEffects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.containerEffects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.containerEffects.Size = new System.Drawing.Size(192, 126);
			this.containerEffects.TabIndex = 8;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Id.Visible = false;
			// 
			// Effects
			// 
			this.Effects.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Effects.HeaderText = "Effects";
			this.Effects.Name = "Effects";
			this.Effects.ReadOnly = true;
			this.Effects.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// buttonEditEffect
			// 
			this.buttonEditEffect.Location = new System.Drawing.Point(381, 63);
			this.buttonEditEffect.Name = "buttonEditEffect";
			this.buttonEditEffect.Size = new System.Drawing.Size(92, 34);
			this.buttonEditEffect.TabIndex = 13;
			this.buttonEditEffect.Text = "Edit Effect";
			this.buttonEditEffect.UseVisualStyleBackColor = true;
			this.buttonEditEffect.Click += new System.EventHandler(this.buttonEditEffect_Click);
			// 
			// buttonRemoveEffect
			// 
			this.buttonRemoveEffect.Location = new System.Drawing.Point(381, 23);
			this.buttonRemoveEffect.Name = "buttonRemoveEffect";
			this.buttonRemoveEffect.Size = new System.Drawing.Size(92, 34);
			this.buttonRemoveEffect.TabIndex = 14;
			this.buttonRemoveEffect.Text = "Remove Effect";
			this.buttonRemoveEffect.UseVisualStyleBackColor = true;
			this.buttonRemoveEffect.Click += new System.EventHandler(this.buttonRemoveEffect_Click);
			// 
			// FormApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRemoveEffect);
			this.Controls.Add(this.buttonEditEffect);
			this.Controls.Add(this.containerEffects);
			this.Controls.Add(this.buttonAddEffect);
			this.Name = "FormApplication";
			this.Text = "osu! Storyboard Editor";
			((System.ComponentModel.ISupportInitialize)(this.containerEffects)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddEffect;
		private System.Windows.Forms.DataGridView containerEffects;
		private System.Windows.Forms.Button buttonEditEffect;
		private System.Windows.Forms.Button buttonRemoveEffect;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Effects;
	}
}