using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MathGameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI firstNumber;
    [SerializeField] TextMeshProUGUI secondNumber;
    [SerializeField] TextMeshProUGUI operation;
    [SerializeField] TextMeshProUGUI puan;
    [SerializeField] TMP_InputField input;
    [SerializeField] TextMeshProUGUI AnswerText;
    [SerializeField] Button btnNewQuestion;

    int res;
    int NumPuan;

    private void Start()
    {
        puan.text = "0";
        AnswerText.text = "";
        YeniSoru();

        btnNewQuestion.interactable = false; // Yeni soru butonunu aktive etmeme
    }

    public void IslemSoncu()
    {
        if (int.Parse(input.text) == res)
        {
            AnswerText.text = "DOĞRU";
            NumPuan += 20;
            puan.text = NumPuan.ToString();
        }
        else
        {
            AnswerText.text = "YANLIŞ";
            NumPuan += -5;
            puan.text = NumPuan.ToString();
        }

        YeniSoru();
        input.text = "";
    }

    public void YeniSoru()
    {
        AnswerText.text = "";
        firstNumber.text = "";
        secondNumber.text = "";
        operation.text = "";

        int numberFirst;
        int numberSecond;
        int op;

        numberFirst = Random.Range(1, 99); // sayıları random bir şekilde oluşturuyoruz
        numberSecond = Random.Range(1, 99); // sayıları random bir şekilde oluşturuyoruz
        op = Random.Range(1, 5); // işlemi random bir şekilde oluşturuyoruz


        switch (op)     // işlemi seçiyoruz
        {
            case 1:
                operation.text = "+";
                res = numberFirst + numberSecond;
                break;

            case 2:
                operation.text = "-";
                res = numberFirst - numberSecond;
                break;

            case 3:
                operation.text = "x";
                res = numberFirst * numberSecond;
                break;

            case 4:
                operation.text = "/";
                res = numberFirst / numberSecond;
                break;
        }

        firstNumber.text = numberFirst.ToString();      // 1. sayı ataması
        secondNumber.text = numberSecond.ToString();     // 2. sayı atamsı

        btnNewQuestion.interactable = true; // Yeni soru butonunu aktive etme
    }
}
