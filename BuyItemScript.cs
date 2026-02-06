using Godot;
using System;

public partial class BuyItemScript : VBoxContainer
{
	[Export] public int buyPrice = 5;
	[Export] public int buyAmount = 1;
	public int buyCost; 
	[Export] public Label buyAmountLabel;
	[Export] public Label buyCostLabel;
		public override void _Ready()
	{
		buyUpdateUI();
		buyAmountLabel.Text = $"{buyAmount}";
		buyCostLabel.Text = $"{buyCost}";
	}	
	public void buyOnPlusPressed()
	{
		buyAmount++;
		buyCost = buyAmount * buyPrice; 
		buyUpdateUI();
	}
	
	public void BuyMatrial()
	{
		if (GameTab.Instance.coin >= buyCost)
		{
			GameTab.Instance.coin -= buyCost;
			GameTab.Instance.materials += buyAmount;
			GameTab.Instance.UpdateCoin.Invoke();
			GameTab.Instance.UpdateMaterial.Invoke();
			GD.Print("Bye Bye coins hello materials");
			buyUpdateUI();
		}
		else{
			GD.Print("not enough coins dude");
			buyUpdateUI();
		}
	}
	
	
	
	public void buyOnMinusPressed()
	{
		
		if (buyAmount > 1)
		{
			buyAmount--;
			buyCost = buyAmount * buyPrice;
			buyUpdateUI();
		}
	}	
	
	
	
		private void buyUpdateUI()
	{
		if (buyCostLabel != null)
		{
			buyCostLabel.Text = $"{buyCost}";
		}
		if (buyAmountLabel != null)
		{
			buyAmountLabel.Text = $"{buyAmount}";
		}
		buyCost = buyAmount * buyPrice;
	}
}
