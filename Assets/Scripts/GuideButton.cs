using UnityEngine;
using UnityEngine.UI;

public class GuideButton : MonoBehaviour
{
    public Image image;
    public Image LargeImage;
    public Image KeyTick;
    public Image DateTick;
    public Image MapTick;
    public Image DecoderTick;
    public Image HackTick;
    public Image LedgerTick;
    public Image CakeTick;

    void Start()
    {
        LargeImage.enabled = false;
        KeyTick.enabled = false;
        DateTick.enabled = false;
        MapTick.enabled = false;
        DecoderTick.enabled = false;
        HackTick.enabled = false;
        LedgerTick.enabled = false;
        CakeTick.enabled = false;
    }

    public void ImageClicked()
    {
        if (image.enabled == true)
        {
            LargeImage.enabled = !LargeImage.enabled;
        }
        if (LargeImage.enabled == true)
        {
            if (GameManager.Instance.Key == true)
            {
                KeyTick.enabled = true;
            }
            if (GameManager.Instance.Date)
            {
                DateTick.enabled = true;
            }
            if (GameManager.Instance.Map)
            {
                MapTick.enabled = true;
            }
            if (GameManager.Instance.Decoder)
            {
                DecoderTick.enabled = true;
            }
            if (GameManager.Instance.Hack)
            {
                HackTick.enabled = true;
            }
            if (GameManager.Instance.LedgersChanged)
            {
                LedgerTick.enabled = true;
            }
            if (GameManager.Instance.CAKE)
            {
                CakeTick.enabled = true;
            }
        }
        else
        {
            KeyTick.enabled = false;
            DateTick.enabled = false;
            MapTick.enabled = false;
            DecoderTick.enabled = false;
            HackTick.enabled = false;
            LedgerTick.enabled = false;
            CakeTick.enabled = false;

        }
    }



}
