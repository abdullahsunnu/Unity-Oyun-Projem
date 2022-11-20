using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CikarmaPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cikarmadairelerdizi;

    [SerializeField]
    private GameObject c1, c2, c3, c4, c5;

    void Start()
    {
        CikarmaScaleKapat();
    }

    public void CikarmaScaleKapat()
    {
        foreach(GameObject Cikarmadizi in cikarmadairelerdizi)
        {
            Cikarmadizi.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }
    public void CikarmaScaleAc(int cikdaire)
    {
        cikarmadairelerdizi[cikdaire].GetComponent<RectTransform>().DOScale(1, 0.3f);

        if(cikdaire%5==0)
        {
            CikarmaScaleKapat();
        }
    }
}

