using UnityEngine;
using UnityEngine.SceneManagement;

public class LedgerChange : MonoBehaviour
{
    public SpriteRenderer ClosedDrawer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameManager.Instance.Check("Decoder") == true && GameManager.Instance.Check("Map") && GameManager.Instance.LedgersChanged == false)
            {
                ClosedDrawer.enabled = false;
                SceneManager.LoadScene("Ledgers", LoadSceneMode.Additive);
            }
            
        }
    }

    void Start()
    {
        if (GameManager.Instance.LedgersChanged == true)
        {
            ClosedDrawer.enabled = false;
        }
    }
}

