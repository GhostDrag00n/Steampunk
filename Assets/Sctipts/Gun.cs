using UnityEngine;
using UnityEngine.UI;
public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public int BacksLeft;
    public Camera fpsCam;
    public Text LeftText;
    public Steam Steam;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetButtonDown("r"))
        {
            if (BacksLeft > 0 && Steam.GetSteamAmount() != 1.0f)
            {
                BacksLeft -= 1;
                Steam.RefillSteam();
                LeftText.text = "A";

            }
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }

    }
}
