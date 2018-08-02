using UnityEngine.SceneManagement;
using UnityEngine;

public class MainManager : MonoBehaviour {

    public int SceneNumb;

    public void StartButton()
    {
        SceneManager.LoadScene(SceneNumb);
    }

}
