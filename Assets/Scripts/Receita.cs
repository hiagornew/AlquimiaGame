using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Receita : MonoBehaviour
{
    [SerializeField] private ReceitaObject[] receita;
    private int _indice = 0;

    [SerializeField] private int[] IdItens;
    
    [SerializeField] private int numeroIngredientes;

    [SerializeField] Image[] ImagemIngrediente;

    [SerializeField] private Image _ReceitaImage;

    [SerializeField] private TextMeshProUGUI _nome;

    [SerializeField] private TextMeshProUGUI _numero;
    [SerializeField] private TextMeshProUGUI _valorVenda;
    [SerializeField] private TextMeshProUGUI _item;
    [SerializeField] private TextMeshProUGUI _qualidade;
    [SerializeField] private TextMeshProUGUI _descricao;

    // Start is called before the first frame update
    void Start()
    {
        DefinirDados(receita[_indice].imageReceita,receita[_indice].imageItensReceita ,receita[_indice].name, receita[_indice].Id, receita[_indice].tipoReceita, receita[_indice].Descricao, receita[_indice].valorVenda, receita[_indice].qualidadeReceita);
    }

    private void DefinirDados(Sprite sprite,Sprite[]sprites, string nome, int id, ReceitaObject.RECEITATYPE type, string descricao, float valorVenda, int qualidade)
    {
        _ReceitaImage.sprite = sprite;
        _nome.text = nome;

        _numero.text = "Nº" + id.ToString();
        _valorVenda.text = "Valor de Venda: " + valorVenda.ToString();
        _item.text = type.ToString();
        _qualidade.text = "Qualidade : " + qualidade.ToString();
        _descricao.text = descricao;
        for (int i = 0; i < sprites.Length; i++)
        {
            ImagemIngrediente[i].sprite = sprites[i];
        }
    }

    public int[] ArrumaEstante()
    {
        return IdItens;
    }

    public void MudarPagina(int sentido)
    {
        _indice += sentido;

        if (_indice >= receita.Length)
        {
            _indice = 0;
        }
        else if (_indice < 0)
        {
            _indice = receita.Length - 1;
        }

        DefinirDados(receita[_indice].imageReceita, receita[_indice].imageItensReceita, receita[_indice].name, receita[_indice].Id, receita[_indice].tipoReceita, receita[_indice].Descricao, receita[_indice].valorVenda, receita[_indice].qualidadeReceita);
    }

   
}
