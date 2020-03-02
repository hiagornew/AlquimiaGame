using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemConfig : ScriptableObject
{
    public int Id;
    public enum ITEMTYPE { POCAO, PEDRA, RUNA, ERVA };
    public string name;
    public Sprite imageItem;
    public Color corItem;
    public ITEMTYPE tipoItem;
    public float valorVenda;
    public int qualidadeItem;
    public Sprite imageMask;

    [TextArea]
    public string Descricao;

    public ItemDate GetDados()
    {
        return new ItemDate(Id, valorVenda, qualidadeItem);
    }

    public void SetDados(ItemDate _itemDate)
    {
        Id = _itemDate.id;
        valorVenda = _itemDate.valorVenda;
        qualidadeItem = _itemDate.qualidadeItem;
    }

}
