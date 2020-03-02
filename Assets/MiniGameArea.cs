using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MiniGameArea : MonoBehaviour
{
    [Header("MiniGameArea Config")]
    public GameObject[] areas;
    public float xMin, xMax;
    public float yMin, yMax;
    public TMP_Text texto;
    public Slider slide;
    public static float intervaloAparecer;

    public static bool chamaTimeAparecer;
    private int quatidadeClick;
    private void Start()
    {
        quatidadeClick = -1;
        chamaTimeAparecer = false;
        ApagaTudo();
        ApareceUm();
    }
    private void Update()
    {
        if (chamaTimeAparecer)
        {

            ApareceUm();
            chamaTimeAparecer = false;
        }

        if (quatidadeClick >= 5)
        {
            texto.text = " Qualidade do Item é: " +  slide.value;
            StartCoroutine(DelayAparecer());
        }
    }

    public void ApagaTudo()
    {
        for (int i = 0; i < areas.Length; i++)
        {
            areas[i].SetActive(false);
        }
    }

    public void ApareceUm()
    {
        int auxI=-1;
        for (int i = 0; i < areas.Length; i++)
        {
            if (areas[i].activeInHierarchy)
            {
                areas[i].SetActive(false);
                auxI = i;
            }
        }
        int rand = Random.Range(0, areas.Length);
        if (rand == auxI)
        {
             rand = Random.Range(0, areas.Length);
        }
        quatidadeClick++;
        areas[rand].SetActive(true);
    }


    IEnumerator DelayAparecer()
    {
        yield return new WaitForSeconds(3);
        this.gameObject.SetActive(false);
       
        
    }

    

}
