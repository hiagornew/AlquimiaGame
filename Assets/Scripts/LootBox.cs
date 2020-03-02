using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class LootBox : MonoBehaviour
{
    public float msTempoEspera = 5000;
    public Button botaoCaixa;
    public TMP_Text timeText;

    //privates
    private ulong ultimaCaixaAberta;
    ulong diff;
    ulong m;
    float secondsLeft;
    private string stringHoraAtual;

    void Start()
    {
       if(PlayerPrefs.HasKey("LastBoxOpen"))
        ultimaCaixaAberta = ulong.Parse(PlayerPrefs.GetString("LastBoxOpen"));

        if (!IsCaixaPronta())
        {
            botaoCaixa.interactable = false;
        }
    }

    void Update()
    {
        if (!botaoCaixa.IsInteractable())
        {
            if (IsCaixaPronta())
            {
                botaoCaixa.interactable = true;
                return;
            }

            stringHoraAtual = "";
            float auxsecondsLeft = (float)(msTempoEspera - m) / 1000.0f;
            //Hours
            stringHoraAtual += ((int)auxsecondsLeft / 3600).ToString() + "h ";
            auxsecondsLeft -= ((int)auxsecondsLeft / 3600) * 3600;
            //Minutes
            stringHoraAtual += ((int)auxsecondsLeft / 60).ToString("00") + "m ";
            //Seconds
            stringHoraAtual += (auxsecondsLeft % 60).ToString("00") + "s";
            timeText.text = stringHoraAtual;

        }
    }

    //Ao clicar no Botão essa função sera chamada
    public void ColocarTempo()
    {
        ultimaCaixaAberta = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastBoxOpen", ultimaCaixaAberta.ToString());
        botaoCaixa.interactable = false;
    }

    private bool IsCaixaPronta()
    {
         diff = ((ulong)DateTime.Now.Ticks - ultimaCaixaAberta);
         m = diff / TimeSpan.TicksPerMillisecond;
         secondsLeft = (float)(msTempoEspera - m) / 1000;
        if (secondsLeft < 0)
        {
            timeText.text = "Pronto!";
            return true;
        }

        return false;
    }


}
