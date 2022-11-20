using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class YildizYonetim : MonoBehaviour
{
    [SerializeField]
    private GameObject sg1, sg2, sg3, sg4, sg5, sg6, sg7, sg8,
                    sa1, sa2, sa3, sa4, sa5, sa6, sa7, sa8;
    void Start()
    {
        sg1.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg2.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg3.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg4.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg5.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg6.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg7.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg8.GetComponent<RectTransform>().localScale = Vector3.zero;

        sa1.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa2.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa3.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa4.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa5.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa6.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa7.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa8.GetComponent<RectTransform>().localScale = Vector3.zero;


    }

    public void yildizAcık(bool dogrumuYanlismi)
    {
        if(dogrumuYanlismi)
        {
            sg1.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg2.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg3.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg4.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg5.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg6.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg7.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sg8.GetComponent<RectTransform>().DOScale(1, 0.2f);

            sa1.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa2.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa3.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa4.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa5.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa6.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa7.GetComponent<RectTransform>().localScale = Vector3.zero;
            sa8.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
        else
        {
            sa1.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa2.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa3.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa4.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa5.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa6.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa7.GetComponent<RectTransform>().DOScale(1, 0.2f);
            sa8.GetComponent<RectTransform>().DOScale(1, 0.2f);

            sg1.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg2.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg3.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg4.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg5.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg6.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg7.GetComponent<RectTransform>().localScale = Vector3.zero;
            sg8.GetComponent<RectTransform>().localScale = Vector3.zero;
            
        }
        Invoke("yildizKapat", 0.8f);
    }

    void yildizKapat()
    {
        sg1.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg2.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg3.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg4.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg5.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg6.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg7.GetComponent<RectTransform>().localScale = Vector3.zero;
        sg8.GetComponent<RectTransform>().localScale = Vector3.zero;

        sa1.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa2.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa3.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa4.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa5.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa6.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa7.GetComponent<RectTransform>().localScale = Vector3.zero;
        sa8.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
