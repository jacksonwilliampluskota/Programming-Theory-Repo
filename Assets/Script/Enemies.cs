using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    public float life;


    virtual public void GoDown()
    {
        transform.Translate(Vector3.up *speed * Time.deltaTime);
    }
}
