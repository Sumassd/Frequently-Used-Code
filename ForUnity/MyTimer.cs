using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 计时器
/// </summary>
public class MyTimer
{
    public enum STATE
    {
        PAUSE,RUN,FINISH
    }
    public STATE timerState; 
    public float duration = 1.0f;
    public float elapsedTime = 0;
    private bool isFinish;

    public bool IsFinish { get { if (timerState == STATE.FINISH) return true;return false; } }

    public MyTimer(float dura)
    {
        duration = dura;
        timerState = STATE.PAUSE;
    }
    public void Tick()
    {
        switch (timerState)
        {
            case STATE.PAUSE:

                break;
            case STATE.RUN:
                if (elapsedTime<duration)
                {
                    elapsedTime += Time.deltaTime;
                }
                else
                {
                    timerState = STATE.FINISH;
                }
                break;
            case STATE.FINISH:
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// 开始计时/初始化计时
    /// </summary>
    public void Go()
    {
        isFinish = false;
        elapsedTime = 0;
        timerState = STATE.RUN;
    }
    public void Go(float duration)
    {
        isFinish = false;
        this.duration = duration;
        elapsedTime = 0;
        timerState = STATE.RUN;
    }

}