using Godot;
using System;

public partial class PlayerScript : CharacterBody2D
{
[Export]
private int speed = 240;
private Vector2 currentVelocity;
private AnimatedSprite2D animatedPlayerSprite;

public override void _PhysicsProcess(double delta)
{
	base._PhysicsProcess(delta);
	handleInput();
	Velocity = currentVelocity;
	MoveAndSlide();
	
}
public void handleInput()
{
	currentVelocity = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
	currentVelocity *= speed;
}

public override void _Ready()
{
	animatedPlayerSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
}

public override void _Process(double delta)
	{
		if (Input.IsActionPressed("ui_right"))
		{
			animatedPlayerSprite.FlipH = false;
			animatedPlayerSprite.Play("Run");
		}
		else if (Input.IsActionPressed("ui_left"))
		{
			animatedPlayerSprite.FlipH = true;
			animatedPlayerSprite.Play("Run");
		}
		else if (Input.IsActionPressed("ui_up"))
		{
			animatedPlayerSprite.FlipH = false;
			animatedPlayerSprite.Play("Run");
		}
		else if (Input.IsActionPressed("ui_down"))
		{
			animatedPlayerSprite.FlipH = false;
			animatedPlayerSprite.Play("Run");
		}
		else
		{
			animatedPlayerSprite.Play("Idle");
		}
	}
}
