using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Command
{

    private PlayerController playerController;

    public Shoot(PlayerController playerController) 
    {
        this.playerController = playerController;
    
    }


    public override void execute()
    {
        playerController.Shoot();
    }
}
