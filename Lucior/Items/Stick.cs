using Terraria.ID;
using Terraria.ModLoader;

namespace Lucior.Items
{
	public class Stick : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stick"); //By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Only the worthy can unlock its TRUE power.");
		}

		public override void SetDefaults() 
		{
			item.damage = 2;
			item.melee = true;
			item.width = 1;
			item.height = 1;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10002;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 0.4f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}