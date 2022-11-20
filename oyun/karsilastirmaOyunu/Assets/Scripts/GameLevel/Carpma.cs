using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Carpma : MonoBehaviour
{
    [SerializeField]
    private GameObject[] carpmadizisi;

    void Start()
    {
        CarpmaScaleKapat();
    }

    public void CarpmaScaleKapat()
    {
        foreach(GameObject carpmadaire in carpmadizisi)
        {
            carpmadaire.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void CarpmaScaleAc(int cardaire)
    {
        carpmadizisi[cardaire].GetComponent<RectTransform>().DOScale(1, 0.3f);

        if(cardaire%5==0)
        {
            CarpmaScaleKapat();
        }
    }

}
