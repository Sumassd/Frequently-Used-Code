using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void RoleEnterHandler();
public delegate void RoleUpdateHandler();
/// <summary>
/// 状态机基类
/// </summary>
public class RoleFSM
{
    public event RoleEnterHandler Enter;
    public event RoleUpdateHandler RoleUpdate;
    //public RoleBase role;//使用状态态机的类
    public virtual void OnEnter()
    {
        //role.currentRoleState = this;//当前状态
        Enter?.Invoke();
    }
    public virtual void Update()
    {
        RoleUpdate?.Invoke();
    }
}