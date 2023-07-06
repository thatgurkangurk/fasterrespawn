using Terraria.DataStructures;
using Terraria.ModLoader;

namespace FastRespawn
{
    public class FastRespawn : Mod
    {
        public class FastRespawnPlayer : ModPlayer
        {

            public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
            {
                Player.respawnTimer = (int)(Player.respawnTimer * .35);
                base.Kill(damage, hitDirection, pvp, damageSource);
            }
        }
    }
}