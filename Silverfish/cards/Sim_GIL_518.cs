using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_518 : SimTemplate //* 飞翼冲击
	{
        //对一个随从造成$4点伤害。如果在本回合中有一个随从死亡，该牌的法力值消耗为（1）点。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {

                int dmg = 4; 
                p.minionGetDamageOrHeal(target, dmg);
            }
        }

    }
}