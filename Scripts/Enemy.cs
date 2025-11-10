using Godot;
using System;

public class Enemy : KinematicBody2D
{
	[Export] public int Speed = 100;
	private Vector2 _velocity = Vector2.Zero;

	public override void _PhysicsProcess(double delta)
	{
		var player = GetNode<Player>("/root/Level1/Player");
		var direction = (player.Position - Position).Normalized();
		_velocity = direction * Speed;
		MoveAndSlide(_velocity);
	}
}
