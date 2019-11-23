using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Powerup {

    public Inventory playerInventory;

	// Use this for initialization
	void Start () {
        powerupSignal.Raise();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SoundManagerScript.PlaySound("Bonus");
            playerInventory.numberOfCoins += 1;
            powerupSignal.Raise();
            Destroy(this.gameObject);

        }
    }
}

