using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaControl : MonoBehaviour
{
    public Image area;
    [Header("Area Config")]
    public float valorAcertado;
    public float valorMax;
    public float valorMin;
    [Range(100,500)]
    public float velocidade;
    public Slider slide;

    //PRIVATES
    private bool aumenta;

    private void Start()
    {
        aumenta = false;
    }
    public void AumentarArea()
    {
        area.transform.localScale += Vector3.right / velocidade ;
        area.transform.localScale += Vector3.up / velocidade;
    }
    public void DiminuirArea()
    {
        area.transform.localScale -= Vector3.right / velocidade;
        area.transform.localScale -= Vector3.up / velocidade ;
    }


    private void Update()
    {
        if (area.transform.localScale.x >= valorMax)
        {
            aumenta = false;
        }
        if (area.transform.localScale.x <= valorMin)
        {
            aumenta = true;
        }
        if(area.transform.localScale.x <= valorAcertado)
        {
            area.color = Color.green;
        }
        else
        {
            area.color = Color.red;

        }

        if (aumenta)
        {
            AumentarArea();
        }
        else
        {
            DiminuirArea();
        }
        
    }

    public void ClicouNoBotao()
    {
        MiniGameArea.chamaTimeAparecer = true;
        if(area.transform.localScale.x <= valorAcertado)
        slide.value += 20;
        else
        slide.value -= 20;
        //this.gameObject.SetActive(false);
    }



}
