using Godot;
using System;

public partial class NPCBasic : Node
{

private AnimatedSprite2D animatedPlayerSprite;

public override void _Ready()
{
	animatedPlayerSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
}
 public void NPCTalk()
{
	
}
public override void _Process(double delta)
{
	while(true)
	{
			animatedPlayerSprite.Play("Idle_healing");
	}
}

}
