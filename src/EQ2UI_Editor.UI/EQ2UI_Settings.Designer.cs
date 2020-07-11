namespace EQ2UI_Editor.UI {
	partial class EQ2UI_Settings {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( ) {
			this.pnlActions = new System.Windows.Forms.Panel();
			this.btnRestart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.pnlSettings = new System.Windows.Forms.Panel();
			this.tabCollection = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.grpApplication = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabEQ2 = new System.Windows.Forms.TabPage();
			this.btnEQ2Directory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlActions.SuspendLayout();
			this.pnlSettings.SuspendLayout();
			this.tabCollection.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tabEQ2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlActions
			// 
			this.pnlActions.Controls.Add(this.btnRestart);
			this.pnlActions.Controls.Add(this.btnCancel);
			this.pnlActions.Controls.Add(this.btnApply);
			this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlActions.Location = new System.Drawing.Point(0, 485);
			this.pnlActions.Name = "pnlActions";
			this.pnlActions.Size = new System.Drawing.Size(800, 33);
			this.pnlActions.TabIndex = 0;
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(108, 5);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(75, 23);
			this.btnApply.TabIndex = 0;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(357, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnRestart
			// 
			this.btnRestart.Location = new System.Drawing.Point(599, 5);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(75, 23);
			this.btnRestart.TabIndex = 2;
			this.btnRestart.Text = "Restart";
			this.btnRestart.UseVisualStyleBackColor = true;
			// 
			// pnlSettings
			// 
			this.pnlSettings.Controls.Add(this.tabCollection);
			this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSettings.Location = new System.Drawing.Point(0, 0);
			this.pnlSettings.Name = "pnlSettings";
			this.pnlSettings.Size = new System.Drawing.Size(800, 485);
			this.pnlSettings.TabIndex = 1;
			// 
			// tabCollection
			// 
			this.tabCollection.Controls.Add(this.tabGeneral);
			this.tabCollection.Controls.Add(this.tabEQ2);
			this.tabCollection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabCollection.Location = new System.Drawing.Point(0, 0);
			this.tabCollection.Name = "tabCollection";
			this.tabCollection.SelectedIndex = 0;
			this.tabCollection.Size = new System.Drawing.Size(800, 485);
			this.tabCollection.TabIndex = 0;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.grpApplication);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(792, 459);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// tabEQ2
			// 
			this.tabEQ2.Controls.Add(this.btnEQ2Directory);
			this.tabEQ2.Controls.Add(this.label1);
			this.tabEQ2.Controls.Add(this.textBox1);
			this.tabEQ2.Location = new System.Drawing.Point(4, 22);
			this.tabEQ2.Name = "tabEQ2";
			this.tabEQ2.Padding = new System.Windows.Forms.Padding(3);
			this.tabEQ2.Size = new System.Drawing.Size(792, 459);
			this.tabEQ2.TabIndex = 1;
			this.tabEQ2.Text = "EverQuest 2";
			this.tabEQ2.UseVisualStyleBackColor = true;
			// 
			// grpApplication
			// 
			this.grpApplication.Location = new System.Drawing.Point(8, 6);
			this.grpApplication.Name = "grpApplication";
			this.grpApplication.Size = new System.Drawing.Size(776, 100);
			this.grpApplication.TabIndex = 0;
			this.grpApplication.TabStop = false;
			this.grpApplication.Text = "Application";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(299, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "EQ2 Directory";
			// 
			// btnEQ2Directory
			// 
			this.btnEQ2Directory.Location = new System.Drawing.Point(311, 22);
			this.btnEQ2Directory.Name = "btnEQ2Directory";
			this.btnEQ2Directory.Size = new System.Drawing.Size(31, 21);
			this.btnEQ2Directory.TabIndex = 2;
			this.btnEQ2Directory.Text = "...";
			this.btnEQ2Directory.UseVisualStyleBackColor = true;
			this.btnEQ2Directory.Click += new System.EventHandler(this.btnEQ2Directory_Click);
			// 
			// EQ2UI_Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 518);
			this.Controls.Add(this.pnlSettings);
			this.Controls.Add(this.pnlActions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EQ2UI_Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "EQ2UI_Settings";
			this.TopMost = true;
			this.pnlActions.ResumeLayout(false);
			this.pnlSettings.ResumeLayout(false);
			this.tabCollection.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabEQ2.ResumeLayout(false);
			this.tabEQ2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlActions;
		private System.Windows.Forms.Button btnRestart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Panel pnlSettings;
		private System.Windows.Forms.TabControl tabCollection;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.GroupBox grpApplication;
		private System.Windows.Forms.TabPage tabEQ2;
		private System.Windows.Forms.Button btnEQ2Directory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}