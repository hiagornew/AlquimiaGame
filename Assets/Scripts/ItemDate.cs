
using System;

[Serializable]
public class ItemDate {
    public int id;
    public float valorVenda;
    public int qualidadeItem;

    public  ItemDate()
    {

    }

    public ItemDate(int _id, float _valorVenda, int _qualidadeItem)
    {
        id = _id;
        valorVenda = _valorVenda;
        qualidadeItem = _qualidadeItem;
    }
   
}
