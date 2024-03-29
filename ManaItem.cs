using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CantTakeMyHearts
{
    internal class ManaItem : GlobalItem
    {
        public override bool AppliesToEntity(Item entity, bool lateInstantiation) => entity.type == ItemID.Star || entity.type == ItemID.SoulCake || entity.type == ItemID.SugarPlum;

        public override bool CanPickup(Item item, Player player)
        {
            return player.statMana < player.statManaMax2;
        }
    }
}
