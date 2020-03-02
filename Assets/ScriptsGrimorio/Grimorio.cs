using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Grimorio : MonoBehaviour
{
    [SerializeField] private ItemConfig[] item;
    private int _indice = 0;

    [SerializeField] private Image _monstroImage;

    [SerializeField] private TextMeshProUGUI _nome;

    [SerializeField] private TextMeshProUGUI _numero;
    [SerializeField] private TextMeshProUGUI _valorVenda;
    //[SerializeField] private TextMeshProUGUI _hp;
    //[SerializeField] private TextMeshProUGUI _xp;
    [SerializeField] private TextMeshProUGUI _item;
    [SerializeField] private TextMeshProUGUI _qualidade;
    [SerializeField] private TextMeshProUGUI _descricao;

    private void Start()
    {
        DefinirDados(item[_indice].imageItem, item[_indice].name, item[_indice].Id, item[_indice].tipoItem, item[_indice].Descricao, item[_indice].valorVenda, item[_indice].qualidadeItem);
    }

    private void DefinirDados(Sprite sprite, string nome, int id, ItemConfig.ITEMTYPE type, string descricao, float valorVenda, int qualidade )
    {
        _monstroImage.sprite = sprite;
        _nome.text = nome;

        _numero.text = "Nº" + id.ToString();
        _valorVenda.text = "Valor de Venda: " + valorVenda.ToString();
       // _hp.text = "HP: " + hp.ToString();
       // _xp.text = "XP: " + xp.ToString();
        _item.text = type.ToString();
        _qualidade.text = "Qualidade : " + qualidade.ToString();
        _descricao.text = descricao;
    }

    public void MudarPagina(int sentido)
    {
        _indice += sentido;

        if (_indice >= item.Length)
        {
            _indice = 0;
        }
        else if (_indice < 0)
        {
            _indice = item.Length - 1;
        }

        DefinirDados(item[_indice].imageItem, item[_indice].name, item[_indice].Id, item[_indice].tipoItem, item[_indice].Descricao, item[_indice].valorVenda, item[_indice].qualidadeItem);
    }
}