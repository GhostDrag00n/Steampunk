using UnityEngine.SceneManagement;
using UnityEngine;

public class MainManager : MonoBehaviour {

    public int SceneToStart;
    public GameObject MainMenu;
    public GameObject Options;

    public void StartButton()
    {
        SceneManager.LoadScene(SceneToStart);
    }

    public void OptionButton()
    {
        MainMenu.SetActive(false);
        Options.SetActive(true);
    }

    public void opBackButton()
    {
        MainMenu.SetActive(true);
        Options.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}