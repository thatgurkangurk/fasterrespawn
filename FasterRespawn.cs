using Terraria.DataStructures;
using Terraria.ModLoader;

namespace FasterRespawn
{
    public class FasterRespawn : Mod
    {
        public class FasterRespawnPlayer : ModPlayer
        {

            public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
            {
                Player.respawnTimer = (int)(Player.respawnTimer * .35);
                base.Kill(damage, hitDirection, pvp, damageSource);
            }
        }
    }
}