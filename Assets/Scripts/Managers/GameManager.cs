using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public int score;
    
    

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) 
        {
            Instance = FindAnyObjectByType<GameManager>();
            if (Instance != null) 
            {
                Destroy(gameObject);
                Instance = this;
            }
            
            
        }
        
        
       
    }

    public void UpdateScore(int amount) 
    {
        score += amount;
    
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
