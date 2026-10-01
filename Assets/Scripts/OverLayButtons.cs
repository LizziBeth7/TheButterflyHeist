using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverLayButtons : MonoBehaviour
{
    public Button TimePiece;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimePiece.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("TimePiece", LoadSceneMode.Additive);
    }
}
