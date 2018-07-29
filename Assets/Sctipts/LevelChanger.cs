using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {
    
    public GameObject LevelManagerUI;
    public GameObject HintUI;
    public GameObject player;
    public Camera MenuCam;
    private void Start()
    {
        LevelManagerUI.SetActive(false);
        HintUI.SetActive(false);
    }

    private void OnTriggerStay(Collider hit)
    {
        bool MenuActive = false;
        if(hit.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown("e"))
            {
                Debug.Log("e");
                if (MenuActive == false)
                {
                    MenuActive = true;
                    HintUI.SetActive(false);
                    //DisableMovement();
                    MenuCam.transform.position = player.transform.position;
                    MenuCam.transform.rotation = player.transform.rotation;
                    player.SetActive(false);
                    Cursor.visible = true;
                    MenuCam.enabled = true;
                    LevelManagerUI.SetActive(true);
                }else{
                    MenuActive = false;
                    HintUI.SetActive(true);
                    //EnableMovement();
                    Cursor.visible = false;
                    player.SetActive(true);
                    MenuCam.enabled = false;
                    LevelManagerUI.SetActive(false);
                }

            }
        }

    }

    private void OnTriggerEnter(Collider hit)
    {
        Debug.Log(hit.gameObject.name);
        Debug.Log(Input.GetKey("e"));
        HintUI.SetActive(true);
        if (hit.gameObject.tag == "Player")
        {
            HintUI.SetActive(true);
        }
    }

    void DisableMovement()
    {
        //player.GetComponentInChildren<Camera>().enabled = false;
        player.SetActive(false);
        Cursor.visible = true;
        MenuCam.transform.position = player.transform.position;
        MenuCam.enabled = true;
        LevelManagerUI.SetActive(true);
    }

    void EnableMovement()
    {
        Cursor.visible = false;
        player.SetActive(true);
        //MenuCam.transform.position = player.transform.position;
        MenuCam.enabled = false;
        LevelManagerUI.SetActive(false);
    }

    private void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            HintUI.SetActive(false);
        }
    }
}
