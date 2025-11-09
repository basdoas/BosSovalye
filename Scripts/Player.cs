using Godot;
using System;

public class Player : KinematicBody2D
{
    [Export] public int Speed = 200;
    [Export] public int JumpForce = 400;
    [Export] public int Gravity = 800;

    private Vector2 _velocity = Vector2.Zero;

    public override void _PhysicsProcess(double delta)
    {
        _velocity.Y += Gravity * (float)delta;

        var direction = Input.GetAxis("move_left", "move_right");
        _velocity.X = direction * Speed;

        if (Input.IsActionJustPressed("jump") && IsOnFloor())
            _velocity.Y = -JumpForce;

        MoveAndSlide();
    }
}