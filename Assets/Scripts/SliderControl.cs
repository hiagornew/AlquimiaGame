using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderControl : MonoBehaviour
{
    private Slider slider;

    [Header("Controles")]
    public float valorAumenta;
    public float valorMAX;
    public float valorMIN;

    [Header("Inputs")]
    public TMP_Text texto;
    //PRIVATES
    private bool limite;
    // Start is called before the first frame update
    void Start()
    {
        limite = false;
        slider = GetComponent<Slider>();
        slider.maxValue = valorMAX;
        slider.minValue = valorMIN;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ChangeValue());
    }

    public float GetValueSlide()
    {
        return slider.value;
    }

    public void PegaValorParaTexto()
    {
        texto.text = GetValueSlide().ToString();
    }

    public void UparSkill()
    {
        valorAumenta--;
        if (valorAumenta <= 0)
        {
            valorAumenta = 0.5f;
        }
    }

    IEnumerator ChangeValue()
    {
       
        if (slider.value >= valorMAX)
        {
            limite = true;
        }
        if(slider.value <= valorMIN)
        {
            limite = false;
        }
        if (limite)
        {
            slider.value -= valorAumenta;
        }
        else
        {
            slider.value += valorAumenta;
        }
        yield return new WaitForSeconds(0.2f);
    }
}
