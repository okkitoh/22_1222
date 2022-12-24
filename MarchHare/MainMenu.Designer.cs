namespace MarchHare {
	partial class MainMenu {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.drawerContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.headerLabel = new System.Windows.Forms.Label();
			this.homePanel = new System.Windows.Forms.Panel();
			this.homeLabel = new System.Windows.Forms.Label();
			this.alarmsPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.clockView1 = new MarchHare.ClockView();
			this.drawerContainer.SuspendLayout();
			this.headerPanel.SuspendLayout();
			this.homePanel.SuspendLayout();
			this.alarmsPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// drawerContainer
			// 
			this.drawerContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.drawerContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.drawerContainer.Controls.Add(this.headerPanel);
			this.drawerContainer.Controls.Add(this.homePanel);
			this.drawerContainer.Controls.Add(this.alarmsPanel);
			this.drawerContainer.Controls.Add(this.panel2);
			this.drawerContainer.Controls.Add(this.panel3);
			this.drawerContainer.Controls.Add(this.panel4);
			this.drawerContainer.Location = new System.Drawing.Point(0, 0);
			this.drawerContainer.Margin = new System.Windows.Forms.Padding(0);
			this.drawerContainer.Name = "drawerContainer";
			this.drawerContainer.Size = new System.Drawing.Size(220, 440);
			this.drawerContainer.TabIndex = 0;
			// 
			// headerPanel
			// 
			this.headerPanel.Controls.Add(this.headerLabel);
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(220, 120);
			this.headerPanel.TabIndex = 0;
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.headerLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.headerLabel.Location = new System.Drawing.Point(33, 42);
			this.headerLabel.Margin = new System.Windows.Forms.Padding(0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(144, 30);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "March Hare";
			this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// homePanel
			// 
			this.homePanel.Controls.Add(this.homeLabel);
			this.homePanel.Location = new System.Drawing.Point(0, 120);
			this.homePanel.Margin = new System.Windows.Forms.Padding(0);
			this.homePanel.Name = "homePanel";
			this.homePanel.Size = new System.Drawing.Size(220, 60);
			this.homePanel.TabIndex = 1;
			// 
			// homeLabel
			// 
			this.homeLabel.AutoSize = true;
			this.homeLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.homeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.homeLabel.Image = ((System.Drawing.Image)(resources.GetObject("homeLabel.Image")));
			this.homeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.homeLabel.Location = new System.Drawing.Point(12, 18);
			this.homeLabel.Name = "homeLabel";
			this.homeLabel.Size = new System.Drawing.Size(129, 28);
			this.homeLabel.TabIndex = 0;
			this.homeLabel.Text = "     Home";
			this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
			// 
			// alarmsPanel
			// 
			this.alarmsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.alarmsPanel.Controls.Add(this.label1);
			this.alarmsPanel.Location = new System.Drawing.Point(0, 180);
			this.alarmsPanel.Margin = new System.Windows.Forms.Padding(0);
			this.alarmsPanel.Name = "alarmsPanel";
			this.alarmsPanel.Size = new System.Drawing.Size(220, 60);
			this.alarmsPanel.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "    Alarms";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(0, 240);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(220, 60);
			this.panel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(12, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 28);
			this.label2.TabIndex = 0;
			this.label2.Text = "    Stopwatch";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(0, 300);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(220, 60);
			this.panel3.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(12, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 28);
			this.label3.TabIndex = 0;
			this.label3.Text = "    Countdown";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(0, 360);
			this.panel4.Margin = new System.Windows.Forms.Padding(0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(220, 60);
			this.panel4.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Location = new System.Drawing.Point(12, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 28);
			this.label4.TabIndex = 0;
			this.label4.Text = "    About";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// clockView1
			// 
			this.clockView1.BackColor = System.Drawing.Color.Transparent;
			this.clockView1.Location = new System.Drawing.Point(247, 120);
			this.clockView1.Margin = new System.Windows.Forms.Padding(0);
			this.clockView1.MinimumSize = new System.Drawing.Size(500, 150);
			this.clockView1.Name = "clockView1";
			this.clockView1.Size = new System.Drawing.Size(500, 150);
			this.clockView1.TabIndex = 1;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(784, 441);
			this.Controls.Add(this.clockView1);
			this.Controls.Add(this.drawerContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MainMenu";
			this.Text = "Form1";
			this.drawerContainer.ResumeLayout(false);
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.homePanel.ResumeLayout(false);
			this.homePanel.PerformLayout();
			this.alarmsPanel.ResumeLayout(false);
			this.alarmsPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion


		private FlowLayoutPanel drawerContainer;
		private Panel headerPanel;
		private Label headerLabel;
		private Panel homePanel;
		private Label homeLabel;
		private Panel alarmsPanel;
		private Label label1;
		private Panel panel2;
		private Label label2;
		private Panel panel3;
		private Label label3;
		private Panel panel4;
		private Label label4;
		private ClockView clockView1;
	}
}

/* What do these do?
 * ResumeLayout
 * SuspendLayout
 * PerformLayout
 *
 */