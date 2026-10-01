using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VaultOpen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public SpriteRenderer Decoder;

    void Start()
    {
        Decoder.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameManager.Instance.Check("Hack") && GameManager.Instance.LedgersChanged)
            {
                Decoder.enabled = true;
                GameManager.Instance.CAKE = true;
                StartCoroutine(Win());
            }
            
        }
    }
    IEnumerator Win()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Victory", LoadSceneMode.Single);
    }
}
