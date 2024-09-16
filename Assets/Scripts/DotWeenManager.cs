using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotWeenManager : MonoBehaviour
{
    public GameObject TABLETRASFROM;
    public GameObject CAM1;
    public GameObject CAM2;


    private void Awake()
    {
        CAM1.SetActive(true);
    }

    private void Update()
    {
        //TABLETRASFROM.transform.DOMove(this.gameObject.transform.position, 0.5f).OnComplete(Bittiginde);

        if (Input.GetKey(KeyCode.Space))
        {
            DoComment();
        }
    }

    public void Bittiginde()
    {
        CAM1.SetActive(false);
        CAM2.SetActive(true);
    }


    public void DoComment()
    {
        TABLETRASFROM.transform.DOShakePosition(5, 5, 5, 10f);
    }

}
