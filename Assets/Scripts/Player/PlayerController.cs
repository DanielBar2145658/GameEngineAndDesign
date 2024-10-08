using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]
    int speed;

    public Transform shootPoint;

    public GameObject bullet;

    private Command shoot;

    private List<Command> buffer;


    private void Awake()
    {
        shoot = new Shoot(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

       

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.AddForce(new Vector3(-speed, 0, 0), ForceMode.Force);
        
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed, 0, 0), ForceMode.Force);


        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            buffer.Add(shoot);
            StartCoroutine(clearBuffer());
        } 
        
    }

    public void Shoot()
    {
        Instantiate(bullet, shootPoint.transform);
    
    }

    IEnumerator clearBuffer() 
    {
        buffer[0].execute();
        yield return new WaitForSeconds(0.02f);
        buffer.Clear();
    }
}
