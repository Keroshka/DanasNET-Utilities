using Exiled.API.Features;
using Exiled.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanasNET_Utilities
{
    public class DNUtilities : Plugin<Config>
    {
        public override string Author => "Keroshka";
        public override Version RequiredExiledVersion => new Version(6, 0, 0);
        public override Version Version => new Version(1, 0, 0);
        public override string Name => "DanasNET-Utilities";

        public DNUtilities Instance = new DNUtilities();
        public EventHandlers handler;
        public override void OnEnabled()
        {
            handler = new EventHandlers(Instance);

            Exiled.Events.Handlers.Server.RoundStarted += handler.OnPlayerSpawn;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= handler.OnPlayerSpawn;

            handler = null;
            base.OnDisabled();
        }
    }
}
