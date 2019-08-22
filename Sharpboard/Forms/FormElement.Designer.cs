namespace Sharpboard.Forms {
	partial class FormElement {
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
			this.containerCommands = new System.Windows.Forms.DataGridView();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonAddFade = new System.Windows.Forms.Button();
			this.inputName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonEditCommand = new System.Windows.Forms.Button();
			this.buttonRemoveCommand = new System.Windows.Forms.Button();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Commands = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.containerCommands)).BeginInit();
			this.SuspendLayout();
			// 
			// containerCommands
			// 
			this.containerCommands.AllowUserToAddRows = false;
			this.containerCommands.AllowUserToDeleteRows = false;
			this.containerCommands.AllowUserToResizeColumns = false;
			this.containerCommands.AllowUserToResizeRows = false;
			this.containerCommands.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
			this.containerCommands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.containerCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.containerCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Commands});
			this.containerCommands.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.containerCommands.Location = new System.Drawing.Point(183, 11);
			this.containerCommands.Name = "containerCommands";
			this.containerCommands.RowHeadersVisible = false;
			this.containerCommands.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.containerCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.containerCommands.Size = new System.Drawing.Size(192, 126);
			this.containerCommands.TabIndex = 7;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(381, 103);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 34);
			this.buttonSave.TabIndex = 8;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseMnemonic = false;
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonAddFade
			// 
			this.buttonAddFade.Location = new System.Drawing.Point(24, 47);
			this.buttonAddFade.Name = "buttonAddFade";
			this.buttonAddFade.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonAddFade.Size = new System.Drawing.Size(76, 36);
			this.buttonAddFade.TabIndex = 9;
			this.buttonAddFade.Text = "Add Fade";
			this.buttonAddFade.UseVisualStyleBackColor = true;
			this.buttonAddFade.Click += new System.EventHandler(this.buttonAddFade_Click);
			// 
			// inputName
			// 
			this.inputName.Location = new System.Drawing.Point(62, 12);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(100, 20);
			this.inputName.TabIndex = 10;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(21, 15);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(35, 13);
			this.labelName.TabIndex = 11;
			this.labelName.Text = "Name";
			// 
			// buttonEditCommand
			// 
			this.buttonEditCommand.Location = new System.Drawing.Point(381, 63);
			this.buttonEditCommand.Name = "buttonEditCommand";
			this.buttonEditCommand.Size = new System.Drawing.Size(92, 34);
			this.buttonEditCommand.TabIndex = 12;
			this.buttonEditCommand.Text = "Edit Command";
			this.buttonEditCommand.UseVisualStyleBackColor = true;
			this.buttonEditCommand.Click += new System.EventHandler(this.buttonEditCommand_Click);
			// 
			// buttonRemoveCommand
			// 
			this.buttonRemoveCommand.Location = new System.Drawing.Point(381, 23);
			this.buttonRemoveCommand.Name = "buttonRemoveCommand";
			this.buttonRemoveCommand.Size = new System.Drawing.Size(92, 34);
			this.buttonRemoveCommand.TabIndex = 13;
			this.buttonRemoveCommand.Text = "Remove Command";
			this.buttonRemoveCommand.UseVisualStyleBackColor = true;
			this.buttonRemoveCommand.Click += new System.EventHandler(this.buttonRemoveCommand_Click);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Id.Visible = false;
			// 
			// Commands
			// 
			this.Commands.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Commands.HeaderText = "Commands";
			this.Commands.Name = "Commands";
			this.Commands.ReadOnly = true;
			this.Commands.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// FormElement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonRemoveCommand);
			this.Controls.Add(this.buttonEditCommand);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.inputName);
			this.Controls.Add(this.buttonAddFade);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.containerCommands);
			this.Name = "FormElement";
			this.Text = "Storyboard Element Editor";
			((System.ComponentModel.ISupportInitialize)(this.containerCommands)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView containerCommands;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonAddFade;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonEditCommand;
		private System.Windows.Forms.Button buttonRemoveCommand;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Commands;
	}
}