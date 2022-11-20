using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DairelerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] dairelerDizisi;

    [SerializeField]
    private GameObject d1, d2, d3, d4, d5, d6, d7, d8,
                    d9, d10, d11, d12, d13, d14, d15, d16,
                    d17, d18, d19, d20, d21, d22, d23, d24, d25;



    void Start()
    {
        DairelerinScaleKapat();
    }

     public void DairelerinScaleKapat()
    {
        foreach(GameObject daire in dairelerDizisi)
        {
            daire.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void DaireninScaleAc(int hangiDaire)
    {
        dairelerDizisi[hangiDaire].GetComponent<RectTransform>().DOScale(1, 0.3f);
        
        if(hangiDaire%5==0)
        {
            DairelerinScaleKapat();
        }
    }

}
