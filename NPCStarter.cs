using Godot;
using System;

public partial class NPCStarter : Node
{

private AnimatedSprite2D animatedPlayerSprite;
[Export] public Control ShopMaterialTabOpen;
[Export] public Control OptionsShopOpen;

public override void _Ready()
{
	animatedPlayerSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
}
 public void NPCTalk()
{
	
}
public override void _Process(double delta)
{				animatedPlayerSprite.Play("Idle_healing");
}
	
	
	

}
