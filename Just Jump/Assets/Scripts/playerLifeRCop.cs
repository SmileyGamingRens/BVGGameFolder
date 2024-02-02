using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLifeRCop : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -1f)
        {
            Die();
        }
    }


    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Enemy Body")) 
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<playerMovement>().enabled = false;
        Invoke(nameof(ReloadLevel1), 1f);
    }

    void ReloadLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }


}
