using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public GameObject PlayerUI;
    public GameObject LevelManagerUI;
    public GameObject HintUI;
    public GameObject player;

    private void Start()
    {
        LevelManagerUI.SetActive(false);
        HintUI.SetActive(false);
    }

    private void OnTriggerStay(Collider hit)
    {
        bool LevelManagerUIActive = false;
        if(hit.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown("e"))
            {
                UnityStandardAssets.Characters.FirstPerson.MouseLook FPC = player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_MouseLook;
                Debug.Log("e");
                if (LevelManagerUIActive == false)
                {
                    LevelManagerUIActive = true;
                    HintUI.SetActive(false);
                    MovementSwitch();
                    FPC.SetCursorLock(false);
                    LevelManagerUI.SetActive(true);
                    PlayerUI.SetActive(true);
                }else{
                    LevelManagerUIActive = false;
                    HintUI.SetActive(true);
                    FPC.SetCursorLock(true);
                    MovementSwitch();
                    LevelManagerUI.SetActive(false);
                    PlayerUI.SetActive(true);
                }

            }
        }

    }

    void MovementSwitch()
    {
        player.GetComponent<CharacterController>().enabled = !player.GetComponent<CharacterController>().enabled;
        player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = !player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled;
        player.GetComponent<Shoot>().enabled = !player.GetComponent<Shoot>().enabled;
    }

    private void OnTriggerEnter(Collider hit)
    {
        Debug.Log(hit.gameObject.name);
        Debug.Log(Input.GetKey("e"));
        if (hit.gameObject.tag == "Player")
        {
            HintUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            HintUI.SetActive(false);
        }
    }
}
