using System;
namespace KrazyK
{
	public class SetBuff:Buff

	{
		private Buff _buff;

		public override void BuffGo()
		{
			throw new NotImplementedException();
		}

		public SetBuff(Buff buff)
		{
			_buff = buff;
		}

	}
}
