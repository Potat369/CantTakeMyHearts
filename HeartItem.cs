using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CantTakeMyHearts
{
    internal class HeartItem : GlobalItem
    {
        public override bool AppliesToEntity(Item entity, bool lateInstantiation) => entity.type == ItemID.Heart || entity.type == ItemID.CandyApple || entity.type == ItemID.CandyCane;
    }
}
