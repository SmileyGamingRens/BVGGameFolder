using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollectorRCop : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;

    private void OnTriggerEnter(Collider other) 
    {
         if (other.gameObject.CompareTag("Coin")) 
        {
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
