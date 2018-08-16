using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeMod.Items.Weapons
{
    public class ControlZombie : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summon Tome");
            Tooltip.SetDefault("Summon Type: Zombie");
        }
        public override void SetDefaults()
        {
            item.noMelee = true;
            item.width = 18;
            item.height = 18;
            item.knockBack = 2;
            item.useStyle = 5;
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
            recipe.AddIngredient(mod.ItemType("ControlBar"));
            recipe.AddIngredient(ItemID.Book);
            recipe.AddTile(mod.TileType("ControlStationTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
