using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace SimpleTransactionExporter
{
	public class SimpleTransactionExporter
	{
		public SimpleTransactionExporter()
		{

		}

		public void LoadCredentials()
		{
		
		}

		public bool LoadAllTransactions()
		{
            var engine = Python.CreateEngine();


			return true;
		}
	}
}
