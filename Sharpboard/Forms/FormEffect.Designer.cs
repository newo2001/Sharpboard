namespace Sharpboard.Forms {
	partial class FormEffect {
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
			this.buttonAddElement = new System.Windows.Forms.Button();
			this.containerElements = new System.Windows.Forms.DataGridView();
			this.buttonEditElement = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.inputName = new System.Windows.Forms.TextBox();
			this.buttonRemoveElement = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Elements = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.containerElements)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddElement
			// 
			this.buttonAddElement.Location = new System.Drawing.Point(24, 47);
			this.buttonAddElement.Name = "buttonAddElement";
			this.buttonAddElement.Size = new System.Drawing.Size(76, 36);
			this.buttonAddElement.TabIndex = 0;
			this.buttonAddElement.Text = "Add Element";
			this.buttonAddElement.UseVisualStyleBackColor = true;
			this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
			// 
			// containerElements
			// 
			this.containerElements.AllowUserToAddRows = false;
			this.containerElements.AllowUserToDeleteRows = false;
			this.containerElements.AllowUserToResizeColumns = false;
			this.containerElements.AllowUserToResizeRows = false;
			this.containerElements.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
			this.containerElements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.containerElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.containerElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Elements});
			this.containerElements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.containerElements.Location = new System.Drawing.Point(183, 11);
			this.containerElements.MultiSelect = false;
			this.containerElements.Name = "containerElements";
			this.containerElements.ReadOnly = true;
			this.containerElements.RowHeadersVisible = false;
			this.containerElements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.containerElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.containerElements.Size = new System.Drawing.Size(192, 126);
			this.containerElements.TabIndex = 8;
			// 
			// buttonEditElement
			// 
			this.buttonEditElement.Location = new System.Drawing.Point(381, 63);
			this.buttonEditElement.Name = "buttonEditElement";
			this.buttonEditElement.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonEditElement.Size = new System.Drawing.Size(92, 34);
			this.buttonEditElement.TabIndex = 9;
			this.buttonEditElement.Text = "Edit Element";
			this.buttonEditElement.UseVisualStyleBackColor = true;
			this.buttonEditElement.Click += new System.EventHandler(this.buttonEditElement_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(21, 15);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 13;
			this.labelName.Text = "Name";
			// 
			// inputName
			// 
			this.inputName.Location = new System.Drawing.Point(62, 12);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(100, 20);
			this.inputName.TabIndex = 12;
			// 
			// buttonRemoveElement
			// 
			this.buttonRemoveElement.Location = new System.Drawing.Point(381, 23);
			this.buttonRemoveElement.Name = "buttonRemoveElement";
			this.buttonRemoveElement.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonRemoveElement.Size = new System.Drawing.Size(92, 34);
			this.buttonRemoveElement.TabIndex = 14;
			this.buttonRemoveElement.Text = "Remove Element";
			this.buttonRemoveElement.UseVisualStyleBackColor = true;
			this.buttonRemoveElement.Click += new System.EventHandler(this.buttonRemoveElement_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(381, 103);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 34);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Elements
			// 
			this.Elements.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Elements.HeaderText = "Elements";
			this.Elements.Name = "Elements";
			this.Elements.ReadOnly = true;
			this.Elements.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// FormEffect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRemoveElement);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.inputName);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonEditElement);
			this.Controls.Add(this.containerElements);
			this.Controls.Add(this.buttonAddElement);
			this.Name = "FormEffect";
			this.Text = "Storyboard Effect Editor";
			((System.ComponentModel.ISupportInitialize)(this.containerElements)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAddElement;
		private System.Windows.Forms.DataGridView containerElements;
		private System.Windows.Forms.Button buttonEditElement;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Button buttonRemoveElement;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Elements;
	}
}