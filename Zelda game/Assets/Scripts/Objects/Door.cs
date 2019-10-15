using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType
{
    key,
    enemy,
    button
}

public class Door : Interactable {

    [Header("Door variables")]
    public DoorType thisDoorType;
    public bool open = false;
    public Inventory playerInventory;
    public SpriteRenderer doorSprite;
    public BoxCollider2D physicsCollider;


   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerInRange && thisDoorType == DoorType.key)
            {
                // have key? if so call open method
                if(playerInventory.numberOfKeys > 0)
                {
                    // Remove key
                    playerInventory.numberOfKeys--;
                    Open();
                }
            }
        }
    }

    public void Open()
    {
        // turn off door sprite renderer
        doorSprite.enabled = false;
        // set open to true
        open = true;
        // turn off door box collider
        physicsCollider.enabled = false;
    }

    public void Close()
    {

    }
}
