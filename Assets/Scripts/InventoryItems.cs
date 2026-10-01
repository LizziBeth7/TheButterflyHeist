using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    public Image image;
    public Image LargeImage;
    
    void Start()
    {
        LargeImage.enabled = false;
    }
        void Update()
    {
        if (GameManager.Instance.Check(gameObject.tag) == false)
        {
            image.enabled = false;
        }
        else
        {
            image.enabled = true;
        }
    }

    public void ImageClicked()
    {
        if (image.enabled == true)
        {
            LargeImage.enabled = !LargeImage.enabled;
        }
    }

    

}
