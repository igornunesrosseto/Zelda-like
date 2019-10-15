using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : Powerup {

    public FloatValue playerHealth;
    public float amountIncrease;
    public FloatValue heartContainers;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerHealth.RuntimeValue += amountIncrease;
            if(playerHealth.initialValue > heartContainers.RuntimeValue * 2f)
            {
                playerHealth.initialValue = heartContainers.RuntimeValue * 2f;
            }
            powerupSignal.Raise();
            Destroy(this.gameObject);

        }
    }
}
