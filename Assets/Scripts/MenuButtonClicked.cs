using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonClicked : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ButtonClicked()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
