using System;
namespace PrinterMgr
{
	public class PrintMgr
	{
		public PrintMgr () {
			Console.WriteLine("Starting...");
		}


		public bool Error () {
			Console.WriteLine("Error");
			return true;
		}


		public bool SpoolError () {
			return true;
		}
	}
}
