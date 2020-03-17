using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrateleiraConfig : MonoBehaviour
{
    public GameObject[] itensPrateleiras;

    public ReceitaObject receita;

    public void CarregaReceita(ReceitaObject receitaAux)
    {
        receita = receitaAux;
    }

    public void CarregaPrateleira()
    {
        itensPrateleiras[0].GetComponent<Image>().sprite = receita.imageItensReceita[0];
    }
}
