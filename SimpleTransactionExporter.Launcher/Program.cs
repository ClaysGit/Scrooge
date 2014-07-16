using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleWebsiteInteractionLibrary;

namespace SimpleTransactionExporter.Launcher
{
	class Program
	{
		static void Main( string[] args )
		{
			GenerateSWIFileForUMCU( "umcu.xml" );
		}

		public static void GenerateSWIFileForUMCU( string filename )
		{
			var umcuSite = new SWISite()
			{
				InitialUrl = "https://www.umcu.org/",
				Page1 = new SWIPage()
				{
					ActionUrl = "https://my.umcu.org/User/AccessSignin/Username",
					Optional = false,
					Fields = new List<SWIField>()
					{
						new SWIField()
						{
							RequiredLabel = null,
							Data = "TTT_USERNAME_TTT",
							Name = "UsernameField"
						}
					}
				},
				Page2 = new SWIPage()
				{
					ActionUrl = "https://my.umcu.org/User/AccessSignin/Password",
					Optional = false,
					Fields = new List<SWIField>()
					{
						new SWIField()
						{
							RequiredLabel = null,
							Data = "TTT_PASSWORD_TTT",
							Name = "PasswordField"
						}
					}
				},
				Page3 = new SWIPage()
				{
					ActionUrl = "https://my.umcu.org/User/AccessSignin/Challenge",
					Optional = true,
					Fields = new List<SWIField>()
					{
						new SWIField()
						{
							RequiredLabel = "TTT_SECQUES1_LABEL_TTT",
							Data = "TTT_SECQUES1_TTT",
							Name = "Answer"
						},
						new SWIField()
						{
							RequiredLabel = "TTT_SECQUES2_LABEL_TTT",
							Data = "TTT_SECQUES2_TTT",
							Name = "Answer"
						},
						new SWIField()
						{
							RequiredLabel = "TTT_SECQUES3_LABEL_TTT",
							Data = "TTT_SECQUES3_TTT",
							Name = "Answer"
						}
					}
				}
			};

			SWISite.ToXmlFile( umcuSite, filename );
		}
	}
}
