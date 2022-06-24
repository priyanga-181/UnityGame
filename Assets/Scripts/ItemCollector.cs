using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins=0;
    public Text coinsText;
    public AudioSource coinSound;

void Start () {
    
}
 private void OnTriggerEnter(Collider other)
 
{
    if(other.gameObject.CompareTag("Coin"))
    {
        Destroy(other.gameObject);
        coins++;
        coinsText.text="Coins: " +coins;
        coinSound.Play();
    }
}


}
