using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace CantTakeMyHearts
{
    internal class CantTakeMyHeartsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [ReloadRequired]
        public List<ItemDefinition> HeartItems = new() { new ItemDefinition(ItemID.Heart), new ItemDefinition(ItemID.CandyApple), new ItemDefinition(ItemID.CandyCane) };

        [ReloadRequired]
        public List<ItemDefinition> ManaItems = new() { new ItemDefinition(ItemID.Star), new ItemDefinition(ItemID.SoulCake), new ItemDefinition(ItemID.SugarPlum) };
    }
}
