using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// MyButton类
/// </summary>
public class MyButton
{
    public bool isPressing;
    public bool onPressed;
    public bool Released;
    private bool currentState;
    private bool lastState;
    /// <summary>
    /// 开始检测指定按钮状态
    /// </summary>
    /// <param name="inputKey"></param>
    public void Tick(bool inputKey)
    {
        currentState = inputKey;
        isPressing = currentState;
        if (!currentState && currentState != lastState)
        {
            Released = true;

        }
        else
        {
            Released = false;
        }
        if (currentState && currentState != lastState)
        {
            onPressed = true;
        }
        else
        {
            onPressed = false;
        }
        lastState = currentState;
    }
}
