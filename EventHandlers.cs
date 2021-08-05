using Exiled.API.Features;
using Exiled.Events.EventArgs;


namespace WarheadPanel_Hint
{
    public class EventHandlers
    {
        public void GeneratorActivated(GeneratorActivatedEventArgs ev)
        {
            foreach (Player ply in Player.List)
            {
                ply.ShowHint(Plugin.Singleton.Config.Hint);
            }
        }
    }
}
