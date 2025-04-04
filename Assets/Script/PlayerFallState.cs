using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallState : PlayerState
{
    public PlayerFallState(PlayerStateMachine stateMachine, Player player, string animBoolName) : base(stateMachine, player, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        player.rb.velocity = new Vector2(player.xInput * player.moveSpeed, player.rb.velocity.y);
        if (player.IsGroundDetected())
            stateMachine.ChangeState(player.idleState);
    }
}