using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Image timerImage;
    public TMP_Text buttomText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.ResetTimer();
        buttomText.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        GameManager.instance.timeRemaining -= Time.deltaTime;
        timerImage.fillAmount = GameManager.instance.timeRemaining / GameManager.instance.maxTime;

        float displayTimer = (Mathf.Round(GameManager.instance.timeRemaining * 100)) / 100;

        buttomText.text = "Time Remaining: " + displayTimer;
    }
}
