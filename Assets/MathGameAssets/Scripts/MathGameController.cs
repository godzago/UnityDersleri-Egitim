using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MathGameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtFirstNumber;
    [SerializeField] TextMeshProUGUI txtSecondNumber;
    [SerializeField] TextMeshProUGUI txtOperation;
    [SerializeField] Text txtPreviousAnswer;
    [SerializeField] TextMeshProUGUI txtScore;
    [SerializeField] TMP_InputField inputAnswer;
    [SerializeField] Button btnGenerateNewQuestion;

    int result;
    int totalScore;

    private int pointsEarned = 20;
    private int pointsLost = -5;
    private int pointsLostForNewQuestion = -3;

    private string emptyString = "";

    private string correctText = "DOĞRU";
    private string incorrectText = "YANLIŞ";

    private int minGeneratedValue = 1;
    private int maxGeneratedValue = 99;


    [SerializeField] private TextMeshProUGUI timerText; // Sayaç göstergesi için
    private float elapsedTime;
    private bool isTimerRunning = false;
    private bool hasReached60Seconds = false; // 60 saniyeye ulaşıldı mı kontrolü
    private bool gameOver = false;


    private void Start()
    {
        YeniSoru();
        txtScore.text = "0";
        btnGenerateNewQuestion.interactable = false; // Yeni soru butonunu aktive etmeme

        StartTimer();
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime; // Zamanı güncelle
            UpdateTimerDisplay(); // UI'ı güncelle
        }
        if (elapsedTime >= 60f && !hasReached60Seconds)
        {
            Debug.Log("Sayaç 60 saniyeye ulaştı!");
            hasReached60Seconds = true;
        }
        if (hasReached60Seconds)
        {
            gameOver = true;

            if (totalScore <= 30)
            {
                SceneManager.LoadScene(2);
            }
            else if (totalScore > 30)
            {
                // Win
                Debug.Log("WİN EKRANI");
                SceneManager.LoadScene(3);           
            }
        }
    }

    public void IslemSoncu()
    {
        if (int.Parse(inputAnswer.text) == result) // Koşul yazılır 
        {
            txtPreviousAnswer.text = correctText;
            totalScore += pointsEarned;
            txtScore.text = totalScore.ToString();
        }
        else
        {
            txtPreviousAnswer.text = incorrectText;
            totalScore += pointsLost;
            txtScore.text = totalScore.ToString();
        }

        inputAnswer.text = emptyString;
        YeniSoru();
    }

    public void YeniSoru()
    {
        txtFirstNumber.text = emptyString;
        txtSecondNumber.text = emptyString;
        txtOperation.text = emptyString;

        int numberFirst;
        int numberSecond;
        int op;

        numberFirst = Random.Range(minGeneratedValue, maxGeneratedValue); // sayıları random bir şekilde oluşturuyoruz
        numberSecond = Random.Range(minGeneratedValue, maxGeneratedValue); // sayıları random bir şekilde oluşturuyoruz
        op = Random.Range(1, 5); // işlemi random bir şekilde oluşturuyoruz

        totalScore += pointsLostForNewQuestion; //   Her Yeni soruda 3 puan gidiyor

        switch (op)     // işlemi seçiyoruz
        {
            case 1:
                txtOperation.text = "+";
                result = numberFirst + numberSecond;
                break;

            case 2:
                txtOperation.text = "-";
                result = numberFirst - numberSecond;
                break;

            case 3:
                txtOperation.text = "x";
                result = numberFirst * numberSecond;
                break;

            case 4:
                txtOperation.text = "/";
                result = numberFirst / numberSecond;
                break;
        }

        txtFirstNumber.text = numberFirst.ToString();      // 1. sayı ataması
        txtSecondNumber.text = numberSecond.ToString();     // 2. sayı atamsı

        btnGenerateNewQuestion.interactable = true; // Yeni soru butonunu aktive etme
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60); // Dakika olarak gösterim
        int seconds = Mathf.FloorToInt(elapsedTime % 60); // Saniye olarak gösterim
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Dakika: Saniye formatında gösterim
    }

    public void StartTimer()
    {
        isTimerRunning = true;
        elapsedTime = 0f;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }
}
