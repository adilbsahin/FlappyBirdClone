using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelMovement : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject,10);
    }

    //boru hareket
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
