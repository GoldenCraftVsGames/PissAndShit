using Terraria.ID;
using Terraria.ModLoader;

namespace PissAndShit.Items
{
	public class BottleSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottle Sword");
			Tooltip.SetDefault("AAAAAAAAAAAAAAAAAAAAAA");
		}
		public override void SetDefaults()
		{
			item.damage = 44;
			item.melee = true;
			item.width = 120;
			item.height = 120;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 9200;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}