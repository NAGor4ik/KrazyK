
namespace KrazyK
{
	public class DeskInGame:AbstraktDesk
	{
		public DeskInGame():base()
		{
		}
		public void Tic() {
			foreach (var i in this._cards)
	//			i.tik();
			RemoteBuf();
		}

		void RemoteBuf() {
			var temp = this._cards;
			foreach (Buff i in temp) {
			/*	if (i.getTime()== 1)
				{
					Hero h = i.getHerro();
					h.remuveBuff(i);
					this._cards.Remove(i);
				}*/
			}
		}

	}
}
