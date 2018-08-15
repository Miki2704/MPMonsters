using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeMod.Items.Weapons
{
    public class ControlRod1 : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 1;
            item.width = 20;
            item.height = 20;
            item.melee = true;
            item.knockBack = 0;
            item.useStyle = 4;
            item.useTime = 20;
            item.useAnimation = 20;
            item.value = 50000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BugNet);
            recipe.AddIngredient(mod.ItemType("ControlBar"), 25);
            recipe.AddTile(mod.TileType("ControlStation"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
