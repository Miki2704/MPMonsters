using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
              
namespace SomeMod.Items.Bars
{
    public class ControlBar : ModItem
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
            item.value = 10000;
            item.rare = 2;
            item.consumable = true;
            item.maxStack = 99;
            item.UseSound = SoundID.Item1;
            item.createTile = mod.TileType("ControlBarTile");
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ControlOre"), 15);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
