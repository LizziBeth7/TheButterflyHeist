using UnityEngine;

public class ItemCollect : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameManager.Instance.Check(gameObject.tag) == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.Collect(gameObject.tag);
            Destroy(gameObject);
            
        }
    }
}
