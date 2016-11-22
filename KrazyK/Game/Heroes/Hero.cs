using System.Collections.Generic;
namespace KrazyK

{
	public abstract class Hero
	{
		private int Health;
		private int Speed;
		private List<ISetBuff> lsdtBuf;
		public Hero()
		{
			lsdtBuf = new List<ISetBuff>();
		}

		public int health {
			get
			{
				return Health;
			}
			set 
			{
				Health = value;
			}

		}
		public int speed { 
			get
			{
				return Speed;
			}
			set
			{
				Speed = value;
			}		
		}
		public void setBuf(ISetBuff buff) {
			lsdtBuf.Add(buff);		
		}
		public void remuveBuff(ISetBuff buff) {
			lsdtBuf.Remove(buff);		
		}

		public void startBuf() {
		/*	foreach (var b in lsdtBuf) {
				int time=b.BuffHero(this);
			}*/
			for (int i = lsdtBuf.Count - 1; i >= 0; i--)
			{
				int time = lsdtBuf[i].BuffHero(this);
				if (time ==1)
					lsdtBuf.RemoveAt(i);
			}
		}
	}
}
