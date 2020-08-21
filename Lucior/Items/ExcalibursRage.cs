using Terraria.ID;
using Terraria.ModLoader;

namespace Lucior.Items
{
	public class ExcalibursRage : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Excalibur's Rage"); //By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("You feel the rage of the excalibur's ancestors stir within its handle.");
		}

		public override void SetDefaults() 
		{
			item.damage = 400;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10001;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 0.7f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Excalibur, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}