using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toyCabeçaDods : Interactable
{

    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public Inventory playerInventory; // para poder modificar inv do player
    public Signal powerupSignal; // // sinal para a classe powerups(para poder mudar coins)




    // Use this for initialization
    void Start()
    {
        powerupSignal.Raise(); // sinal para a classe powerups(para poder mudar coins)
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);

                // ao falar com cabeça de dods, perde 1 coin
                playerInventory.numberOfCoins -= 1;
                powerupSignal.Raise();
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

   

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerInRange = false;
            context.Raise();
            dialogBox.SetActive(false);
        }
    }
}