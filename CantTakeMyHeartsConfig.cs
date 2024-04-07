using System.Collections.Generic;
using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace CantTakeMyHearts
{
    [BackgroundColor(46, 12, 46)]
    internal class CantTakeMyHeartsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [BackgroundColor(196, 29, 111)]
        [ReloadRequired]
        public List<ItemDefinition> HeartItems = new() { new ItemDefinition(ItemID.Heart), new ItemDefinition(ItemID.CandyApple), new ItemDefinition(ItemID.CandyCane) };

        [BackgroundColor(70, 29, 199)]
        [ReloadRequired]
        public List<ItemDefinition> ManaItems = new() { new ItemDefinition(ItemID.Star), new ItemDefinition(ItemID.SoulCake), new ItemDefinition(ItemID.SugarPlum) };

        [BackgroundColor(196, 29, 111)]
        public int HealthDeficit = 20;

        [BackgroundColor(70, 29, 199)]
        public int ManaDificit = 20;
    }
}
