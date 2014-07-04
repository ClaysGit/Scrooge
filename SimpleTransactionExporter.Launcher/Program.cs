using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleTransactionExporter;

namespace SimpleTransactionExporter.Launcher
{
	class Program
	{
		static void Main( string[] args )
		{
			var transactionDownloader = new SimpleTransactionExporter();

			var csv = transactionDownloader.LoadAllTransactions();

			Console.Write( "Received response XX characters long\n" );
		}
	}
}
