using System;
namespace KrazyK
{
	public class GameManager
	{
		public GameManager()
		{
			Melee Ivan = new Melee();
			AddHealth h50 = new AddHealth(50);
			AddHealth h10 = new AddHealth(-10,3);
			Ivan.setBuf(h50);
			Ivan.setBuf(h10);
			Ivan.startBuf();
		}
	}
}
