using Exiled.API.Features;
using System;
using MapHandler = Exiled.Events.Handlers.Map;

namespace WarheadPanel_Hint
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public override string Author { get; } = "xNexus";
        public override string Name { get; } = "Warhead Hint";
        public override string Prefix { get; } = "WH";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 11, 1);

        private EventHandlers _handler;

        public override void OnEnabled()
        {
            
            
            _handler = new EventHandlers();

            MapHandler.GeneratorActivated += _handler.GeneratorActivated;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            
            _handler = null;

            MapHandler.GeneratorActivated -= _handler.GeneratorActivated;

            base.OnDisabled();
        }
    }
}
