using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject healthbar;
    public float health = 100f;

    private void Update()
    {
        healthbar.GetComponent<Image>().fillAmount = health / 100f;
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
