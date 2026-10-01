using UnityEngine;
using UnityEngine.UI;

public class SpriteChangeDecoder : MonoBehaviour
{
    public Image EmptyDecoder;
    public Sprite SolvedDecoder;
    void Update()
    {
        if (GameManager.Instance.Check("Map") == true)
        {
            EmptyDecoder.sprite = SolvedDecoder;
        }
    }
}
