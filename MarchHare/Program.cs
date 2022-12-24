using Microsoft.VisualBasic.ApplicationServices;

namespace MarchHare {
	internal static class Program {

		/* What are STA (Single-Threaded Apartments)?
		 *    Non-blocking
		 *    Pump message loop for COM CoInitializeEx()
		 * https://stackoverflow.com/questions/4154429/apartmentstate-for-dummies
		 */
		[STAThread]
		static void Main() {
			
			// ** Enable Console Logging for WinForms
			// Solution Right Click > Properties > Application > General > Output type = "Console Application"

			// ** Copy Resource to Output Directory
			// Resources > Image file > Properties > 
			//		> Build Action: Content
			//		> Copy to Output Directory: Copy Always



			ApplicationConfiguration.Initialize();
			Application.Run(new MainMenu());
			// Console.WriteLine does not run here. Seems like they have a foreground thread to run
			// the UI which blocks the main thread from exiting until the foreground UI thread signals
			// termination

		}

	}
}