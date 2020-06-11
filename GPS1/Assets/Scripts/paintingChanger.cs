using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paintingChanger : MonoBehaviour
{
    Image currentImage;
    public Sprite newGame;
    public Sprite goodEnding;
    public Sprite badEnding;
    public Sprite secretEnding;

    void Start()
    {
        currentImage = GetComponent<Image>();    
    }

    void Update()
    {
        if (Global.state == 0)
        {
            currentImage.sprite = newGame;
        }
        if(Global.state == 1)
        {
            currentImage.sprite = goodEnding;
        }
        if (Global.state == 2)
        {
            currentImage.sprite = badEnding;
        }
        if (Global.state == 3)
        {
            currentImage.sprite = secretEnding;
        }
    }
}
