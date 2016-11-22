namespace KrazyK
{
	public class AddHealth: Buff

	{
		//private Hero _hero;
		private int _buff=0;
		public AddHealth(int buff)
		{
			_buff = buff;
		}
		public AddHealth(int buff, int time) :base(time){
			_buff = buff;
		}

		public override void BuffGo()
		{
			//base._hero = hero;
			_hero.health += _buff;
		}
	}
}
