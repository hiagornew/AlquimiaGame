using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Receita", menuName = "Receita")]
public class ReceitaObject : ScriptableObject
{
    public int Id;
    public enum RECEITATYPE { POCAO, PEDRA, RUNA, ERVA };
    public string name;
    public Sprite imageReceita;
    public Color corItem;
    public RECEITATYPE tipoReceita;
    public float valorVenda;
    public int qualidadeReceita;
    public Sprite imageMask;

    [TextArea]
    public string Descricao;
}
