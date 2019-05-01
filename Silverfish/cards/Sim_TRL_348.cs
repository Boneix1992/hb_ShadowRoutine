using System;
using System.Collections.Generic;
using System.Text;
using Triton.Game.Data;
using log4net;
using Logger = Triton.Common.LogUtilities.Logger;

namespace HREngine.Bots
{
	class Sim_TRL_348 : SimTemplate //魔泉山猫
	{
        private static readonly ILog Log = Logger.GetLoggerInstanceForType();

//    miao
            public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
            {
                Log.Info("魔泉山猫 觸發突襲...");
                own.cantAttackHeroes = true;
            }

            public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
            {
                if(triggerEffectMinion.own == turnStartOfOwner) triggerEffectMinion.cantAttackHeroes = false;
            }

	}
}