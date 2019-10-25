using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPowerUp : Powerup
{
    public float magicValue;
    public Inventory playerInventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

 public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !other.isTrigger)
        {
            playerInventory.currentMagic += magicValue;
            powerupSignal.Raise();
            Destroy(this.gameObject);
        }
    }
}
