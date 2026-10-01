using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeLedgers : MonoBehaviour
{
    public Button ChangeButton;
    public Image OriginalLedgers;
    public Sprite ChangedLedgers;

    void Start()
    {
        ChangeButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        OriginalLedgers.sprite = ChangedLedgers;
        GameManager.Instance.LedgersChanged = true;
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("BankVault", LoadSceneMode.Single);
    }
}

