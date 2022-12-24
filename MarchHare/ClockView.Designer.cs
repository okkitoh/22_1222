namespace MarchHare {
	partial class ClockView {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.clockHeader = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.clockBody = new System.Windows.Forms.Panel();
			this.hrDisplay = new System.Windows.Forms.Label();
			this.separator = new System.Windows.Forms.Label();
			this.minDisplay = new System.Windows.Forms.Label();
			this.separator2 = new System.Windows.Forms.Label();
			this.secDisplay = new System.Windows.Forms.Label();
			this.clockHeader.SuspendLayout();
			this.clockBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// clockHeader
			// 
			this.clockHeader.BackColor = System.Drawing.Color.Transparent;
			this.clockHeader.Controls.Add(this.label1);
			this.clockHeader.Location = new System.Drawing.Point(0, 0);
			this.clockHeader.Margin = new System.Windows.Forms.Padding(0);
			this.clockHeader.Name = "clockHeader";
			this.clockHeader.Size = new System.Drawing.Size(500, 50);
			this.clockHeader.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(500, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "local time";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// clockBody
			// 
			this.clockBody.Controls.Add(this.hrDisplay);
			this.clockBody.Controls.Add(this.separator);
			this.clockBody.Controls.Add(this.minDisplay);
			this.clockBody.Controls.Add(this.separator2);
			this.clockBody.Controls.Add(this.secDisplay);
			this.clockBody.Location = new System.Drawing.Point(0, 50);
			this.clockBody.Margin = new System.Windows.Forms.Padding(0);
			this.clockBody.Name = "clockBody";
			this.clockBody.Size = new System.Drawing.Size(500, 100);
			this.clockBody.TabIndex = 0;
			// 
			// hrDisplay
			// 
			this.hrDisplay.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.hrDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.hrDisplay.Location = new System.Drawing.Point(0, 0);
			this.hrDisplay.Name = "hrDisplay";
			this.hrDisplay.Size = new System.Drawing.Size(100, 100);
			this.hrDisplay.TabIndex = 0;
			this.hrDisplay.Text = "00";
			this.hrDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// separator
			// 
			this.separator.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.separator.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.separator.Location = new System.Drawing.Point(100, 0);
			this.separator.Name = "separator";
			this.separator.Size = new System.Drawing.Size(100, 100);
			this.separator.TabIndex = 0;
			this.separator.Text = ":";
			this.separator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// minDisplay
			// 
			this.minDisplay.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.minDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.minDisplay.Location = new System.Drawing.Point(200, 0);
			this.minDisplay.Name = "minDisplay";
			this.minDisplay.Size = new System.Drawing.Size(100, 100);
			this.minDisplay.TabIndex = 0;
			this.minDisplay.Text = "00";
			this.minDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// separator2
			// 
			this.separator2.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.separator2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.separator2.Location = new System.Drawing.Point(300, 0);
			this.separator2.Name = "separator2";
			this.separator2.Size = new System.Drawing.Size(100, 100);
			this.separator2.TabIndex = 0;
			this.separator2.Text = ":";
			this.separator2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// secDisplay
			// 
			this.secDisplay.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.secDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.secDisplay.Location = new System.Drawing.Point(400, 0);
			this.secDisplay.Name = "secDisplay";
			this.secDisplay.Size = new System.Drawing.Size(100, 100);
			this.secDisplay.TabIndex = 0;
			this.secDisplay.Text = "00";
			this.secDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClockView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.clockHeader);
			this.Controls.Add(this.clockBody);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MinimumSize = new System.Drawing.Size(500, 150);
			this.Name = "ClockView";
			this.Size = new System.Drawing.Size(500, 150);
			this.Load += new System.EventHandler(this.ClockView_Load);
			this.clockHeader.ResumeLayout(false);
			this.clockBody.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel clockHeader;
		private Panel clockBody;
		private Label label1;
		private Label hrDisplay;
		private Label minDisplay;
		private Label secDisplay;
		private Label separator;
		private Label separator2;
	}
}
