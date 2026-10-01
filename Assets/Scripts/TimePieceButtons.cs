using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Threading;


public class TimePieceButtons : MonoBehaviour
{
    private int picker =0;
    public Button TimepieceButton;
    public RectTransform rectTransform;
    private float duration = 0.8f;

    public string[] years = new string[] { "1916", "1926", "1946", "1986", "2006", "2026" };
    //public GameObject visitedOverlay;
    //public GameObject[] visitedOverlays = new GameObject[6];



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimepieceButton.onClick.AddListener(TaskOnClick);
    }

 private IEnumerator SpinRoutine(int RotateSpeed, int yearIdx)
    {
        float timePassed = 0f;

        while (timePassed < duration)
        {
            // Spin on the Z-axis for UI elements
            rectTransform.Rotate(0f, 0f, RotateSpeed * Time.deltaTime);
            
            timePassed += Time.deltaTime;
            yield return null; // Wait for the next frame
        }
        Thread.Sleep(200);
        Debug.Log("change");
        SceneManager.LoadScene(years[yearIdx], LoadSceneMode.Single);

        //Code Section By Mylo
        // GameObject thisVisitedOverlay = visitedOverlays[yearIdx];
        //thisVisitedOverlay.SetActive(true);
        // thisVisitedOverlay.transform.Rotate(0f, 0f, 60 * yearIdx);

        // GameObject thisVisitedOverlay = Instantiate(visitedOverlay, transform.position, transform.rotation);
        // thisVisitedOverlay.transform.Rotate(0f, 0f, 60 * yearIdx);
        // Debug.Log(yearIdx);
        // Debug.Log(years[yearIdx]);
        // Debug.Log(thisVisitedOverlay.name);
    }

    void TaskOnClick()
    {
        picker = Random.Range(1, 7);

        if (picker == 2 && GameManager.Instance.Check("Date") == false)
        {
            picker = 1;
        }


        if (picker == 1)
        {
            StartCoroutine(SpinRoutine(412, 0));
        }
        else if (picker == 2)
        {
            StartCoroutine(SpinRoutine(500, 1));
        }
        else if (picker == 3)
        {
            StartCoroutine(SpinRoutine(562, 2));
        }
        else if (picker == 4)
        {
            StartCoroutine(SpinRoutine(625, 3));
        }
        else if (picker == 5)
        {   StartCoroutine(SpinRoutine(712, 4));
        }
        else if (picker == 6)
        {
            StartCoroutine(SpinRoutine(787, 5));
        }
        else
        {
            Debug.Log("Error");
        }

        

        
    }
}
