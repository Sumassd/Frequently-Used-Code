using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool
{

    [SerializeField] public GameObject poolGuy;//池对象
    public Queue<GameObject> queue;//队列/池
    [SerializeField] public int count;
    public Transform parent;
    public void InitPool(Transform parent)//初始化池
    {
        this.parent = parent;
        queue = new Queue<GameObject>();
        for (int i = 0; i < count; i++)
        {
            GameObject pg = MakeOnePoolGuy();
            //pg.transform.parent = parent;//
            queue.Enqueue(pg);
        }
    }
    ///生成一个对象
    private GameObject MakeOnePoolGuy()
    {
        GameObject result = GameObject.Instantiate(poolGuy);
        result.transform.parent = this.parent;
        result.SetActive(false);
        return result;
    }
    /// <summary>
    ///从池中选一个poolGuy
    /// </summary>
    private GameObject GetAvailabeGuyFromPool()
    {
        GameObject result = null;
        if (count>0&&queue.Peek().activeSelf==false)
        {
            result = queue.Dequeue();
        }
        else
        {
            result = MakeOnePoolGuy();
        }
        queue.Enqueue(result);//出列后立即入列，此时处于activeSelf=true状态
        return result;
    }
    /// <summary>
    /// 获取一个启用的池对象
    /// </summary>
    /// <returns></returns>
    public GameObject GetPreparedPoolGuy()
    {
        GameObject result = null;
        result = GetAvailabeGuyFromPool();
        result.SetActive(true);
        return result;
    }
    /// <summary>
    /// 获取一个启用的池对象
    /// </summary>
    /// <param name="pos"></param>
    /// <returns></returns>
    public GameObject GetPreparedPoolGuy(Vector3 pos)
    {
        GameObject result = null;
        result = GetAvailabeGuyFromPool();
        result.transform.position = pos;
        result.SetActive(true);
        return result;
    }
    /// <summary>
    /// 获取一个启用的池对象
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="rotation"></param>
    /// <returns></returns>
    public GameObject GetPreparedPoolGuy(Vector3 pos,Quaternion rotation)
    {
        GameObject result = null;
        result = GetAvailabeGuyFromPool();
        result.transform.position = pos;
        result.transform.rotation = rotation;
        result.SetActive(true);
        return result;
    }
    /// <summary>
    /// 获取一个启用的池对象
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="rotation"></param>
    /// <param name="scale"></param>
    /// <returns></returns>
    public GameObject GetPreparedPoolGuy(Vector3 pos,Quaternion rotation,Vector3 scale)
    {
        GameObject result = null;
        result = GetAvailabeGuyFromPool();
        result.transform.position = pos;
        result.transform.rotation = rotation;
        result.transform.localScale = scale;
        result.SetActive(true);
        return result;
    }
}
