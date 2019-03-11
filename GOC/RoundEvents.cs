using Smod2.API;
using Smod2.EventHandlers;
using Smod2.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOC
{
    class RoundEvents : IEventHandlerRoundStart
    {

        int index = GOC.rand.Next(0, 101);

        public void OnRoundStart(RoundStartEvent ev)
        {
            foreach (Player p in ev.Server.GetPlayers())
            {
                if (p.TeamRole.Role == Role.FACILITY_GUARD && index >                                                                                                                                                                                                                                                                                                                                                                                                                                                   )
                {
                    p.ChangeRole(Role.NTF_COMMANDER);
                }
            }
        }
    }
}
