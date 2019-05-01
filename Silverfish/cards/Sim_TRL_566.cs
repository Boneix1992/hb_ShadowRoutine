using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_566 : SimTemplate //荒野的复仇
	{

//    Summon your Beasts that died this turn.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int diedMinions = (ownplay) ? p.tempTrigger.ownBeastDied : p.tempTrigger.enemyBeastDied;
            if (diedMinions == 0) return;
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

			// 我也想招个米莎啊
        	CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_554t);//snake
        	
        	for (int i = 0; i < diedMinions; i++)
        	{
				p.callKid(kid, pos, ownplay);
            
            }

		}

	}
}