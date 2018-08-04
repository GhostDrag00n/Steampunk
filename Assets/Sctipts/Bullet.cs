using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float damage;

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Enemy")
        {
            hit.gameObject.GetComponent<AIController>().TakeDamage(damage);
        }
    }
}
