using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MarchHare {
	// Gets the annoying designer view out of the way
	// [System.ComponentModel.DesignerCategory("")]
	public partial class MainMenu: Form {

		public MainMenu() {
			InitializeComponent();
			Console.WriteLine(this.clockView1.BackColor);
		}

		// TODO demo animation of sliding current view up and out of bounds
		private void homeLabel_Click(object sender,EventArgs e) {
			this.BeginInvoke(() => FadeOut(this.clockView1, 30));
		}
		
		private async void FadeOut(Control control, int interval = 10) {
			for(int i = 0; i < 20; i++) {
				await Task.Delay(interval);
				Point p = control.Location;
				control.Location = new Point(p.X, p.Y - 50);
			}

			
		}
	}
}

/* WinForms don't have an animation library afaik 
 * Typical solutions involve creating a WPF control widget and embedding. Note for future projects or last resort.
 * Manually simulate animations by dialing control styles with some maths. Nothing too fancy.
 * 
 */