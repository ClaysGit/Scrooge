using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace SimpleWebsiteInteractionLibrary
{
	public class SWISite
	{
		public static SWISite FromXmlFile( string filePath )
		{
			var xmlSerializer = new XmlSerializer( typeof( SWISite ) );
			var fileStream = new FileStream( filePath, FileMode.Open );
			return (SWISite)xmlSerializer.Deserialize( fileStream );
		}

		public static void ToXmlFile( SWISite site, string filePath )
		{
			var xmlSerializer = new XmlSerializer( typeof( SWISite ) );
			var fileStream = new FileStream( filePath, FileMode.CreateNew );
			xmlSerializer.Serialize( fileStream, site );
		}

		public string InitialUrl { get; set; }
		public SWIPage Page1 { get; set; }
		public SWIPage Page2 { get; set; }
		public SWIPage Page3 { get; set; }
	}

	public class SWIPage
	{
		public SWIPage()
		{
			Fields = new List<SWIField>();
		}

		public string ActionUrl { get; set; }
		public bool Optional { get; set; }

		public List<SWIField> Fields { get; set; }
	}

	public class SWIField
	{
		public string RequiredLabel { get; set; }
		public string Data { get; set; }
		public string Name { get; set; }
	}
}
