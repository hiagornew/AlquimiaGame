using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private int ID;

    private string name;
    private string type;
    private int qualidade;
    private Color cor;
    public bool preenchido;
    public void OnDrop(PointerEventData eventData)
    {
       if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //Debug.Log(eventData.pointerDrag.GetComponent<Item>().itemConfig.name);
            preenchido = true;
            
            name = eventData.pointerDrag.GetComponent<Item>().itemConfig.name;
            type = eventData.pointerDrag.GetComponent<Item>().itemConfig.tipoItem.ToString();
            cor = eventData.pointerDrag.GetComponent<Item>().itemConfig.corItem;
            qualidade = eventData.pointerDrag.GetComponent<Item>().itemConfig.qualidadeItem;
            ID = eventData.pointerDrag.GetComponent<Item>().itemConfig.Id;
        }
        else
        {
            
            preenchido = false;
        }
    }

    public string PegaConfigItemName()
    {
        return name;
    }
    public Color PegaConfigItemColor()
    {
        return cor;
    }

    public int PegaId()
    {
        return ID;
    }
    public int PegaConfigQualidade()
    {
        return qualidade;
    }

    public string PegaConfigItemType()
    {
        return type;
    }

    
}
