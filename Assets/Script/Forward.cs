using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    [SerializeField] float speed = 200.0f;
    void Update()
    {
        transform.Translate(Vector3.up *speed * Time.deltaTime);
    }
}
