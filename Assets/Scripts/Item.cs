using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Image image;
    public ItemConfig itemConfig;

    private void Awake()
    {
        image = GetComponent<Image>();
        image.sprite = itemConfig.imageItem;
    }
    private void Start()
    {
        image = GetComponent<Image>();
        image.sprite = itemConfig.imageItem;
    }

    public void CarregaInfo()
    {
        image = GetComponent<Image>();
        image.sprite = itemConfig.imageItem;
    }
}
