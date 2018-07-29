using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject handeler;
    public GameObject bullet;
    public float fireRate = 10f;
    public float forse = 3000;
    public Steam Steam;
    public float SteamUsage;
    public int BacksLeft;
    public Text LeftText;
    private float nextTimeToFire = 0;
    public int Ammo;
    public int ammoInMagazine;
    public int ammoLeft;
    public Text AmmoText;

    private void Start()
    {
        AmmoText.text = ammoLeft.ToString() + " / " + Ammo.ToString();
    }

    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && Steam.GetSteamAmount() > 0 && ammoLeft > 0)
        {
            ammoLeft -= 1;
            AmmoText.text = ammoLeft.ToString() + " / " + Ammo.ToString();
            nextTimeToFire = Time.time + 1f / fireRate;
            Steam.DecreaseAmountOfSteam(SteamUsage);
            GameObject temp = Instantiate(bullet, handeler.transform.position, handeler.transform.rotation) as GameObject;

            Rigidbody tempRb;
            tempRb = temp.GetComponent<Rigidbody>();
            tempRb.AddForce(transform.forward * forse);

            Destroy(temp, 10.0f);
        }
        if (Input.GetKeyDown("t"))
        {
            if (BacksLeft > 0 && Steam.GetSteamAmount() != 1.0f)
            {
                BacksLeft -= 1;
                Steam.RefillSteam();
                LeftText.text = BacksLeft.ToString();

            }
        }
        if (Input.GetKeyDown("r") && Ammo > 0)
        {
            if (Ammo > ammoInMagazine)
            {
                Ammo -= ammoInMagazine - ammoLeft;
                ammoLeft = ammoInMagazine;
                AmmoText.text = ammoLeft.ToString() + " / " + Ammo.ToString();
            }
            else
            {
                int AmmoTaken = ammoInMagazine - Ammo;
                ammoLeft += Ammo;
                Ammo -= AmmoTaken;
                AmmoText.text = ammoLeft.ToString() + " / " + Ammo.ToString();
            }
        }
    }
}