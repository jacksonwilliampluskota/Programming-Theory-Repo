using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : Enemies
{
    private void Awake()
    {
        speed = 1.0f;
        life = 10.0f;
    }


    private void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);

        }
    }

}
