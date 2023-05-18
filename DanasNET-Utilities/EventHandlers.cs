using CommandSystem.Commands.RemoteAdmin;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.API.Features.Roles;
using MapGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DanasNET_Utilities
{
    public class EventHandlers
    {
        private DNUtilities _plugin;

        public EventHandlers(DNUtilities singleton)
        {
            _plugin = singleton;
        }

        public void OnPlayerSpawn()
        {
            var players = Exiled.API.Features.Player.List.Where(peanut => peanut.Role.Type == PlayerRoles.RoleTypeId.Scp173).ToList();
            var position = Exiled.API.Extensions.SpawnExtensions.GetPosition(Exiled.API.Enums.SpawnLocationType.InsideNukeArmory);
            if (position != Vector3.zero)
            {
                foreach (var player in players)
                {
                    player.Teleport(Exiled.API.Extensions.SpawnExtensions.GetPosition(Exiled.API.Enums.SpawnLocationType.InsideNukeArmory));
                }
            } 
        }
    }
}
