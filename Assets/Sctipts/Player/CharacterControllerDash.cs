using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerDash : MonoBehaviour {

    public float dashPower = 5;
    private Rigidbody player;
    private Vector3 pts;
    private void Start()
    {
        player = this.GetComponent<Rigidbody>();
        pts = player.transform.forward;
    }
    void Update () {
        if (Input.GetKeyDown("f"))
        {
            player.transform.Translate(new Vector3(pts.x * dashPower, pts.y * dashPower, pts.z * dashPower));
        }
	}
}
