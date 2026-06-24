using System.Data.Entity;
using System.Linq;
using Grammophone.Domos.Tests.Music.Cases;
using Grammophone.Domos.Tests.Music.DataAccess.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grammophone.Domos.Tests.Music.Cases.EntityFramework
{
	/// <summary>
	/// EF6 music logic tests.
	/// </summary>
	[TestClass]
	public class EFMusicLogicTests : MusicLogicTestCases
	{
		protected override string ConfigurationSectionName => "musicLogic";

		protected override void ResetData()
		{
			Database.SetInitializer(new DropCreateDatabaseAlways<EFMusicDomosDomainContainer>());

			var innerContainer = new EFMusicDomosDomainContainer("default");
			innerContainer.Database.Initialize(true);

			using (var domainContainer = new EFMusicDomosDomainContainerAdapter(innerContainer))
			{
				MusicTestDataSeeder.Seed(domainContainer);
			}

			Database.SetInitializer<EFMusicDomosDomainContainer>(null);

			using (var verificationContainer = new EFMusicDomosDomainContainer("default"))
			{
				if (!verificationContainer.Users.Any(user => user.UserName == MusicTestData.AdminUserName))
				{
					throw new System.InvalidOperationException("The music test database was not seeded.");
				}
			}
		}
	}
}
