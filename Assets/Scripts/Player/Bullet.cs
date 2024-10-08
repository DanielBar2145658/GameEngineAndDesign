using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    int speed;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
