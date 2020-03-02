using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ResultadoAlquimia : MonoBehaviour
{
    // Start is called before the first frame update
    public ItemSlot[] slotItens;
    public ItemConfig[] resultados;
    public TMP_Text textoResultado;
    public Image imageResultado;
    public GameObject PainelQualidade;
    private int resultadoID;
    private int posicaoResultado;
    private bool resultado;
    private void Update()
    {
        if(slotItens[0].preenchido && slotItens[1].preenchido)
        {
            CalculaResultadoID(slotItens[0].PegaId(), slotItens[1].PegaId());
            PainelQualidade.SetActive(true);
            //Resultado();
        }
        else
        {
            LimpaResultado();

        }
    }
    public void Resultado(int IdResult)
    {
        if (IdResult == 3)
        {
            textoResultado.text = "Voce Conseguiu fazer a Poção Verde";
        }
        else if (IdResult == 9)
        {
            textoResultado.text = "Voce Conseguiu fazer a Poção Laranja";
        }
        else
        {
            textoResultado.text = "Voce misturou: " + slotItens[0].PegaConfigItemType() + " Com " + slotItens[1].PegaConfigItemType() + " e a qualidade do Item é: " + slotItens[1].PegaConfigQualidade();
        }
        imageResultado.color = resultados[posicaoResultado].corItem;
        imageResultado.sprite = resultados[posicaoResultado].imageItem;
        slotItens[0].preenchido = false;
        slotItens[1].preenchido = false;
    }

    public void LimpaResultado()
    {
        textoResultado.text = "";
    }


    public void CalculaResultadoID(int idslot1, int idslot2)
    {
        for (int i = 0; i < resultados.Length; i++)
        {
            if(resultados[i].Id == idslot1 + idslot2)
            {
                resultadoID = resultados[i].Id;
                posicaoResultado = i;
                Resultado(resultadoID);
                break;
            }
        }
    }



}
