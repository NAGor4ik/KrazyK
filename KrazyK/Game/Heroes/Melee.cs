using System;
namespace KrazyK
{
	public class Melee:Hero
	{
		private int _meleeAtak = 3;

		public Melee():base()
		{
			health = 10;
			speed = 1;
		}
		public int meleeAtak { get { return _meleeAtak;} private set { _meleeAtak = value; } }
	}
}
