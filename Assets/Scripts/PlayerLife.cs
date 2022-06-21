using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
   
    void Start()
    {
        Debug.Log("Hello");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy Body"))
        {
            Die();
        }
    }
   void Die() 
   {
    GetComponent<MeshRenderer>().enabled=false;
    GetComponent<Rigidbody>().isKinematic=true;
    GetComponent<PlayerMovement>().enabled=false;
    ReloadLevel();

   }

   void ReloadLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}