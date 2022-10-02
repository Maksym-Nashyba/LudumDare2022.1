﻿using Misc;
using NPCs;
using UnityEngine;

namespace Player.Movement
{
    public sealed class HumanoidMovement: PlayerMovement
    {
        private readonly LivingNPC _host;

        public HumanoidMovement(LivingNPC host)
        {
            _host = host;
        }

        public override void SetPlayerDestination()
        {
            (RaycastHit hit, bool success) hitInfo = ScreenRaycasting.GetScreenRaycastHit();
            if(!hitInfo.success) return;
            _host.WalkToPosition(hitInfo.hit.point);
        }

        public override void TurnOffNavMesh()
        {
            _host.enabled = false;
        }
    }
}