using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CantTakeMyHearts
{
    internal class HeartItem : GlobalItem
    {
        public override bool AppliesToEntity(Item entity, bool lateInstantiation) 
        {
            foreach (ItemDefinition itemDefinition in ModContent.GetInstance<CantTakeMyHeartsConfig>().HeartItems)
            {
                if (entity.type == itemDefinition.Type)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool CanPickup(Item item, Player player)
        {
            return player.statLife <= player.statLifeMax2 - ModContent.GetInstance<CantTakeMyHeartsConfig>().HealthDeficit;
        }
    }
}
