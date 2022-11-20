using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bolme : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bolmedizisi;

    void Start()
    {
        BolmeScaleKapat();
    }
    public void BolmeScaleKapat()
    {
        foreach(GameObject bolmedaire in bolmedizisi)
        {
            bolmedaire.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void BolmeScaleAc(int boldaire)
    {
        bolmedizisi[boldaire].GetComponent<RectTransform>().DOScale(1, 0.3f);

        if(boldaire%5==0)
        {
            BolmeScaleKapat();
        }
    }
}
