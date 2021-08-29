using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    void Update()
    {
        if (Random.Range(0, 100) < 5)
        {
            GameObject a = PoolManager.singleton.Get("Asteroid");

            if (a != null)
            {
                a.transform.position = this.transform.position +
                                       new Vector3(Random.Range(-4.4f, 4.4f), 0, 0);
                a.SetActive(true);
            }
        }


    }
}
