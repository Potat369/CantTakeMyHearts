using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace CantTakeMyHearts
{
    internal class ManaItem : GlobalItem
    {
        public override bool AppliesToEntity(Item entity, bool lateInstantiation) 
        { 
            foreach (ItemDefinition itemDefinition in ModContent.GetInstance<CantTakeMyHeartsConfig>().ManaItems)
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
            return player.statMana < player.statManaMax2;
        }
    }
}
