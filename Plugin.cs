using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarheadPanel_Hint
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Author { get; } = "xNexus";
        public override string Name { get; } = "Warhead Hint";
        public override string Prefix { get; } = "WH";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 11, 1);

        private EventHandlers _handler;

        public override void OnEnabled()
        {
            Instance = this;
            Log.Info("Plugin Cargado");
            _handler = new EventHandlers();

            Exiled.Events.Handlers.Map.GeneratorActivated += _handler.GeneratorActivated;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            _handler = null;

            Exiled.Events.Handlers.Map.GeneratorActivated -= _handler.GeneratorActivated;

            base.OnDisabled();
        }
    }
}
