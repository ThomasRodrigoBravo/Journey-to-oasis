using Godot;
using System;

public partial class ExitButtonScript : Panel
{
	[Export] public Control ShopMaterialTab;
	
	private bool shouldShow = true;
	public void ToggleShop ()
	{
			ShopMaterialTab.Visible = false;
			ShopMaterialTab.ProcessMode = ProcessModeEnum.Disabled;		
	}
}
