using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
			Trace.AutoFlush = true;
			Trace.Listeners.Add(tr2);
			Trace.WriteLine(string.Format("new log time : {0}", DateTime.Now.ToString()));
#if DEBUG
			Trace.WriteLine(string.Format("debug"));
#else
			Trace.WriteLine(string.Format("release"));
#endif

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
