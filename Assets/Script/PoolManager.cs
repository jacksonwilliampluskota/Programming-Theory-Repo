using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PoolItem
{
    public GameObject prefab;
    public int amount;
    public bool expandable;

}

public class PoolManager : MonoBehaviour
{
    public static PoolManager singleton;
    public List<PoolItem> items;
    public List<GameObject> polledItems;

    void Awake()
    {
        singleton = this;
    }

    public GameObject Get(string tag)
    {
        for (int i = 0; i < polledItems.Count; i++)
        {
            if (!polledItems[i].activeInHierarchy && polledItems[i].tag == tag)
            {
                return polledItems[i];
            }
        }

        foreach (PoolItem item in items)
        {
            if (item.prefab.tag == tag && item.expandable)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                polledItems.Add(obj);
                return obj;
            }
        }

        return null;
    }

    void Start()
    {
        polledItems = new List<GameObject>();

        foreach (PoolItem item in items)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                polledItems.Add(obj);
            }
        }

    }
}