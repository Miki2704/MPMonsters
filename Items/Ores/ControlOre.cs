using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeMod.Items.Ores
{
    public class ControlOre : ModItem
    {
        
        public override void SetDefaults()
        {
            item.melee = false;
            item.noMelee = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.width = 12;
            item.height = 12;
            item.value = 5000;
            item.rare = 2;
            item.consumable = true;
            item.maxStack = 999;
            item.UseSound = SoundID.Item1;
            item.createTile = mod.TileType("ControlOreTile");
            item.autoReuse = true;
        }
    }
}
