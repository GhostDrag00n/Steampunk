using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float health = 100f;

    private void Update()
    {
        if (health <= 0)
        {
            Die();   
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("Died");
        //adassss
    }
}
