using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_111 : SimTemplate //猎头者之斧
	{

		//    如果你控制一个野兽，便获得+1耐久度。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            bool first = false;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET)
                {                    
        			first = true;
                    break;
                }
            }

            if (first){
                CardDB.Card weapon2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_111e1);
                p.equipWeapon(weapon2, ownplay);
            }else{
                CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_111);
                p.equipWeapon(weapon, ownplay);
            }

		}

	}
}