using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 120.0f; // 2 минуты
    public Text countdownText;
    [SerializeField] private GameObject loseWindow;
    public AudioSource tick;

    private bool playedAfterFiveSeconds = false;
    private bool playedAfterFiveSeconds1 = false;
    private bool playedAfterFiveSeconds2 = false;
    private bool playedAfterFiveSeconds3 = false;
    private bool playedAfterFiveSeconds4 = false;
    private bool playedAfterFiveSeconds5 = false;
    public bool solvedStopTimer = false;

    void Update()
    {
        if (!solvedStopTimer)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = 0;
                loseWindow.SetActive(true);
            }

            DisplayTime(timeLeft);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeToDisplay < 6 && !playedAfterFiveSeconds)
        {
            tick.PlayOneShot(tick.clip);
            playedAfterFiveSeconds = true;
        }
        if (timeToDisplay < 5 && !playedAfterFiveSeconds1)
        {
            tick.PlayOneShot(tick.clip);
            playedAfterFiveSeconds1 = true;
        }
        if (timeToDisplay < 4 && !playedAfterFiveSeconds2)
        {
            tick.PlayOneShot(tick.clip);
            playedAfterFiveSeconds2 = true;
        }
        if (timeToDisplay < 3 && !playedAfterFiveSeconds3)
        {
            tick.PlayOneShot(tick.clip);
            playedAfterFiveSeconds3 = true;
        }
        if (timeToDisplay < 2 && !playedAfterFiveSeconds4)
        {
            tick.PlayOneShot(tick.clip);
            playedAfterFiveSeconds4 = true;
        }
        if (timeToDisplay < 1 && !playedAfterFiveSeconds5)
        {
            tick.PlayOneShot(tick.clip);
            playedAfterFiveSeconds5 = true;
        }

        if (Mathf.CeilToInt(timeToDisplay) <= 6)
        {
            countdownText.color = Color.red;
        }
    }
}