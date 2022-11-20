using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ToplamaPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject[] toplamadairelerdizi;

    [SerializeField]
    private GameObject t1, t2, t3, t4, t5;

    void Start()
    {
        ToplamaScaleKapat();
    }

    public void ToplamaScaleKapat()
    {
        foreach(GameObject toplamadizi in toplamadairelerdizi)
        {
            toplamadizi.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }
    public void ToplamaScaleAc(int topdaire)
    {
        toplamadairelerdizi[topdaire].GetComponent<RectTransform>().DOScale(1, 0.3f);

        if(topdaire%5==0)
        {
            ToplamaScaleKapat();
        }
    }
}

