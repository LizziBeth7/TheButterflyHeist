using UnityEngine;
using UnityEngine.SceneManagement;

public class BankDoorOpen : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameManager.Instance.Check("Key") == true)
            {
                SceneManager.LoadScene("BankTellers", LoadSceneMode.Single);
            }
            
        }
    }
}
