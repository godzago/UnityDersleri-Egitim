using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVManager : MonoBehaviour
{
    public GameObject Tv80;

    public GameObject Tv70;

    private void Awake()
    {
        //Debug.Log("BEN ÝLK UYANDIÐIMDA ÇALIÞAN METODUM.");
    }

    void Start()
    {
        //Debug.Log("BEN ÝLK SANÝYE ÇALIÞAN METODUM.");       
    }

    private void OnEnable()
    {
        //Debug.Log("BEN BAÐLI OLDUÐUM OBJE ÝLK ÇALIÞTIÐINDA ÇALIÞAN METODUM.");

        Tv70.SetActive(true);
        Tv80.SetActive(false);
    }

    void Update()
    {
        //Debug.Log("BEN ÝLK HER SANÝYE ÇALIÞAN METODUM.");
    }

    private void OnDisable()
    {
        //Debug.Log("BEN BAÐLI OLDUÐUM OBJE KAPANDIÐINDA ÇALIÞAN METODUM.");

        //Tv80.SetActive(true);
        //Tv70.SetActive(false);
    }
}
