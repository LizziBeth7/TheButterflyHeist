using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ExitButtonClicked()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene("2026", LoadSceneMode.Single);
    }
}
