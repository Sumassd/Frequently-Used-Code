using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void RoleEnterHandler();
public delegate void RoleUpdateHandler();
/// <summary>
/// 状态机接口
/// </summary>
public class FSMState
{
    public PlayerState state;
    public PlayerAnimationController playerAC;
    /// <summary>
    /// 进入状态调用
    /// </summary>
    public virtual void OnEnter()
    {
        this.playerAC.currentState = this;
        Enter();
    }
    /// <summary>
    /// 进入动画
    /// </summary>
    public virtual void Enter()
    {

    }
    /// <summary>
    /// 转换状态调用
    /// </summary>
    public virtual void OnExit()
    {
        this.playerAC.lastState = this;
    }
    /// <summary>
    /// 状态转
    /// </summary>
    public virtual void StateTransition()
    {

    }
}
public class TBKFSMState
{
    public RoleBase role;
    /// <summary>
    /// 进入状态调用
    /// </summary>
    public virtual void OnEnter()
    {
        role.currentState = this;
        Enter();
    }
    /// <summary>
    /// 进入动画
    /// </summary>
    public virtual void Enter()
    {

    }
    /// <summary>
    /// 转换状态调用
    /// </summary>
    public virtual void OnExit()
    {
       
    }
    /// <summary>
    /// 状态转
    /// </summary>
    public virtual void Update()
    {

    }
}
public class RoleFSM
{
    public RoleBase role;
    public virtual void OnEnter()
    {
        role.currentRoleState = this;
        Enter?.Invoke();
    }
    public virtual void Update()
    {
        RoleUpdate?.Invoke();
    }
    public event RoleEnterHandler Enter;
    public event RoleUpdateHandler RoleUpdate;
}
public class IdleRoleState : RoleFSM
{
    public IdleRoleState(RoleBase role)
    {
        this.role = role;
    }
}
public class RunRoleState : RoleFSM
{
    public RunRoleState(RoleBase role)
    {
        this.role = role;
    }
}
public class CrouchRoleState : RoleFSM
{
    public CrouchRoleState(RoleBase role)
    {
        this.role = role;
    }
}
public class JumpRoleState : RoleFSM
{
    public JumpRoleState(RoleBase role)
    {
        this.role = role;
    }
}
public class DeathRoleState : RoleFSM
{
    public DeathRoleState(RoleBase role)
    {
        this.role = role;
    }
}
public class FallRoleState : RoleFSM
{
    public FallRoleState(RoleBase role)
    {
        this.role = role;
    }
}
public class HitRoleState : RoleFSM
{
    public HitRoleState(RoleBase role)
    {
        this.role = role;
    }
}
