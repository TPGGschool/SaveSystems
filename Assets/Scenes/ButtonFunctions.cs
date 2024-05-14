using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
  

    // cambiar de escena
    public void changeToScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }





}

