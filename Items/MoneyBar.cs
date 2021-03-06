﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PissAndShit.Items
{
    public class MoneyBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Money Bar");
            Tooltip.SetDefault("Cost big money");
        }
        public override void SetDefaults()
        {
            item.rare = 5;
            item.width = 30;
            item.height = 24;
            item.maxStack = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 50);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
