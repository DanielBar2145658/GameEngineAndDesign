using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die() 
    {
        GameManager.Instance.UpdateScore(10);
    
    }

    private void OnTriggerEnter(Collider other)
    {
        Die();
    }
}
