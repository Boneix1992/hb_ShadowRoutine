using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_348t : SimTemplate //魔泉山猫 小弟
	{

            public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
            {
                own.cantAttackHeroes = true;
            }

            public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
            {
                if(triggerEffectMinion.own == turnStartOfOwner) triggerEffectMinion.cantAttackHeroes = false;
            }

	}
}