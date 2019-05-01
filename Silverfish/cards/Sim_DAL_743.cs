using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Triton.Game.Data;
using log4net;
using Logger = Triton.Common.LogUtilities.Logger;


namespace HREngine.Bots
{
	class Sim_DAL_743 : SimTemplate //荆棘帮斗猪
	{
        private static readonly ILog Log = Logger.GetLoggerInstanceForType();

        //    heng
    		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
    		{
                Log.Info("荆棘帮斗猪 觸發突襲...");
                own.cantAttackHeroes = true;
    		}

		    public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
            {
                if(triggerEffectMinion.own == turnStartOfOwner) triggerEffectMinion.cantAttackHeroes = false;
            }

            public override void onDeathrattle(Playfield p, Minion m)
            {
            	p.drawACard(CardDB.cardIDEnum.DAL_743t, m.own,true);
            }

	}
}