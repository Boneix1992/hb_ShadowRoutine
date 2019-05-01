using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_347 : SimTemplate // 诱饵射击
	{

//    造成$3点伤害。<b>超杀：</b>召唤一个5/5的魔暴龙。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {

                int dmg = 3; 
                if (target.Hp < 3)
                {
                    CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_347t);
                    int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(kid, pos, ownplay);
                } 
                p.minionGetDamageOrHeal(target, dmg);
            }
		}

	}
}