using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Button StartButton;
    public Button ExitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartButton.onClick.AddListener(StartTaskOnClick);
        ExitButton.onClick.AddListener(ExitTaskOnClick);

    }

    // Update is called once per frame
    void StartTaskOnClick()
    {
        SceneManager.LoadScene("Info", LoadSceneMode.Single);
    }

    void ExitTaskOnClick()
    {
        Application.Quit();
    }
}
