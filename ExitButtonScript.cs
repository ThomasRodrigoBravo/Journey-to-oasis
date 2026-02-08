using Godot;
using System;

public partial class ExitButtonScript : Panel
{
	[Export] public Control ShopMaterialTabOpen;
	[Export] public Control OptionsShopOpen;
	public void ToggleShopClose()
	{
		ShopMaterialTabOpen.Visible = !ShopMaterialTabOpen.Visible;
		OptionsShopOpen.Visible = !OptionsShopOpen.Visible;
	}
	
}
