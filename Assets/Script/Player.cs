using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    Vector2 _horizontalInput;
    Rigidbody playerRb;
    [SerializeField] GameObject startShoot;
    [SerializeField] GameObject bullet;

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            _horizontalInput = context.ReadValue<Vector2>();

        }
    }

    public void DetectMouse(InputAction.CallbackContext context)
    {
        if(context.performed){
            GameObject b = PoolManager.singleton.Get("Bullet");
            if (b != null)
            {
                b.transform.position = startShoot.transform.position;
                b.SetActive(true);
            }
        }
    }

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        playerRb.velocity = Vector3.right * _horizontalInput * speed * Time.deltaTime;
    }
}
