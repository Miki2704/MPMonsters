using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeMod.Items.Weapons
{
    public class ControlSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Control Sword");
            Tooltip.SetDefault("A powerful weapon!");
        }
        public override void SetDefaults()
        {
            item.damage = 100;
            item.width = 40;
            item.height = 40;
            item.melee = true;
            item.knockBack = 5;
            item.useStyle = 1;
            item.useTime = 20;
            item.useAnimation = 20;
            item.value = 50000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ControlBar"), 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
