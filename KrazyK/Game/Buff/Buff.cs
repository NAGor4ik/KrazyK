using System;
namespace KrazyK
{
	abstract public class Buff:ISetBuff
	{
		protected Hero _hero;
		int _time ;
		public Buff(int time=1)
		{
			_time = time;
		}
		public void tik(int delta=1) {
			_time -= delta;
			if (_time < 1)
				_time = 1;
		}

		public abstract void BuffGo();

		virtual public int BuffHero(Hero hero)
		{
			this._hero = hero;
			BuffGo();
			tik();
			return _time;
		}
	}
}
