using Godot;
using System;

public partial class SellItemScript : VBoxContainer
{
	
	[Export] public int sellPrice = 5;
	[Export] public int sellAmount = 1;
	private int sellCost;
	[Export] public Label sellAmountLabel;
	[Export] public Label sellCostLabel;
	
	public override void _Ready()
	{
		sellUpdateUI();
		sellAmountLabel.Text = $"{sellAmount}";
		sellCostLabel.Text = $"{sellCost}";
	}
	
	public void sellOnPlusPressed()
	{
		sellAmount++;
		sellCost = sellAmount * sellPrice;
		sellUpdateUI();
	}
	
	public void SellMatrial()
	{
		if (GameTab.Instance.materials >= sellAmount)
		{
			GameTab.Instance.materials -= sellAmount;
			GameTab.Instance.coin += sellCost;
			GameTab.Instance.UpdateCoin.Invoke();
			GameTab.Instance.UpdateMaterial.Invoke();
			GD.Print("Bye Bye material hello coin");
			sellUpdateUI();
		}
		else{
			GD.Print("not enough materials dude");
			sellUpdateUI();
		}
	}
	
	
	
	public void sellOnMinusPressed()
	{
		
		if (sellAmount > 1)
		{
			sellAmount--;
			sellCost = sellAmount * sellPrice;
			sellUpdateUI();
		}
	}	
	
		private void sellUpdateUI()
	{
		if (sellCostLabel != null)
		{
			sellCostLabel.Text = $"{sellCost}";
		}
		if (sellAmountLabel != null)
		{
			sellAmountLabel.Text = $"{sellAmount}";
		}
		sellCost = sellPrice * sellAmount;
	}
}
