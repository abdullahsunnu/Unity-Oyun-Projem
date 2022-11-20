using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Buttontoplama : MonoBehaviour
{
    [SerializeField]
    private GameObject toplambutonn;
    void Start()
    {
        toplambutonn.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
    public void toplamdgr(bool toplamdogrumu)
    {
        if(toplamdogrumu)
        {
            toplambutonn.GetComponent<RectTransform>().DOScale(1, 0.2f);
            
        }
        else
        {
            toplambutonn.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
        Invoke("btnkapat", 0.8f);
    }
    void btnkapat()
    {
        toplambutonn.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
