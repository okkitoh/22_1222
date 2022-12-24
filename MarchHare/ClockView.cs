using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarchHare {
	public partial class ClockView:UserControl {
		public ClockView() {
			InitializeComponent();
		}

		private void ClockView_Load(object sender,EventArgs e) {
			Thread th = new Thread(StartClockUpdating);
			th.Start();
		}

		// (1) Executed in a new background thread
		private void StartClockUpdating() {
			while(true) {
				if(!IsHandleCreated) {
					// (3) background thread ends whenever handle is destroyed
					break;
				}
				// (2) Critical zone locking within threadspace to modify UI elements safely(?)
				// Is it doing something like the background thread joins with
				// the UI thread (clockView control context) for just a moment
				// to run  the callback (UpdateClock) within the
				// UI thread context? 
				// 
				// It works for now. Need to do some more research.
				BeginInvoke(new UpdateClockDelegate(UpdateClock));
				Thread.Sleep(1000);
			}
		}

		private delegate void UpdateClockDelegate();
		private void UpdateClock() {
			DateTime now = DateTime.Now;
			hrDisplay.Text = now.Hour.ToString();
			minDisplay.Text = now.Minute.ToString();
			secDisplay.Text = now.Second.ToString();
		}
	}
}

// Reference Article
// https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls