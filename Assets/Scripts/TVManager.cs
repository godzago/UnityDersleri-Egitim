using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVManager : MonoBehaviour
{
    public GameObject Tv80;

    public GameObject Tv70;

    private void Awake()
    {
        //Debug.Log("BEN �LK UYANDI�IMDA �ALI�AN METODUM.");
    }

    void Start()
    {
        //Debug.Log("BEN �LK SAN�YE �ALI�AN METODUM.");       
    }

    private void OnEnable()
    {
        //Debug.Log("BEN BA�LI OLDU�UM OBJE �LK �ALI�TI�INDA �ALI�AN METODUM.");

        Tv70.SetActive(true);
        Tv80.SetActive(false);
    }

    void Update()
    {
        //Debug.Log("BEN �LK HER SAN�YE �ALI�AN METODUM.");
    }

    private void OnDisable()
    {
        //Debug.Log("BEN BA�LI OLDU�UM OBJE KAPANDI�INDA �ALI�AN METODUM.");

        //Tv80.SetActive(true);
        //Tv70.SetActive(false);
    }
}
