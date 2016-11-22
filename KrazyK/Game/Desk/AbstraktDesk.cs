using System.Collections.Generic;
namespace KrazyK
{
	public class AbstraktDesk
	{
		protected List<Buff> _cards;
		public AbstraktDesk()
		{
			_cards = new List<Buff>();
		}
		public void addCards(Buff buff)
		{
			_cards.Add(buff);
		}
		public void removeCards(Buff buff)
		{
			_cards.Remove(buff);
		}
	}
}
