using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeMod.Items.MiscPlaceable
{
    public class ControlStation : ModItem
    {
        public override void SetDefaults()
        {
            item.melee = false;
            item.noMelee = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.width = 20;
            item.height = 20;
            item.value = 5000;
            item.rare = 2;
            item.consumable = true;
            item.maxStack = 99;
            item.UseSound = SoundID.Item1;
            item.createTile = mod.TileType("ControlStationTile");
            item.autoReuse = false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinkerersWorkshop);
            recipe.AddIngredient(mod.ItemType("ControlBar"), 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
