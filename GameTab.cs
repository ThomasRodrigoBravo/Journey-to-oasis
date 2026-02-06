using Godot;
using System;

public partial class GameTab : Panel
{
	public static GameTab Instance { get; private set; }
	
	public Action UpdateMaterial;
	public Action UpdateCoin;
	
	[Export] public int coin = 50;
	[Export] public Label CoinLabel;
	[Export] public int materials = 50;
	[Export] public Label MaterialLabel;
	
	
	
		public override void _Ready()
	{
		Instance = this;
		GameTab.Instance.UpdateCoin += RefreshCoin;
		GameTab.Instance.UpdateMaterial += RefreshMaterial;
	}

	private void RefreshCoin()
	{
		CoinLabel.Text = $"{coin}";
	}
	
	
		private void RefreshMaterial()
	{
		MaterialLabel.Text = $"{materials} wood";
	}

}
