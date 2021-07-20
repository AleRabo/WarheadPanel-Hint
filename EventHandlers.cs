using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarheadPanel_Hint
{
    public class EventHandlers
    {
        public void GeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            foreach (Player ply in Exiled.API.Features.Player.List)
            {
                ply.ShowHint(Plugin.Instance.Config.Hint);
            }
        }
    }
}
