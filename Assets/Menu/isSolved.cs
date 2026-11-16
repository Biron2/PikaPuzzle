using UnityEngine;
using YG;

public class isSolved : MonoBehaviour
{
    private GameObject solved;

    private void Start()
    {
        solved = transform.Find("solved").gameObject;
        if (gameObject.name.Equals("puzzle1") && YandexGame.savesData.solved_1){
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle2") && YandexGame.savesData.solved_2)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle3") && YandexGame.savesData.solved_3)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle4") && YandexGame.savesData.solved_4)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle5") && YandexGame.savesData.solved_5)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle6") && YandexGame.savesData.solved_6)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle7") && YandexGame.savesData.solved_7)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle8") && YandexGame.savesData.solved_8)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle9") && YandexGame.savesData.solved_9)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle10") && YandexGame.savesData.solved_10)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle11") && YandexGame.savesData.solved_11)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle12") && YandexGame.savesData.solved_12)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle13") && YandexGame.savesData.solved_13)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle14") && YandexGame.savesData.solved_14)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle15") && YandexGame.savesData.solved_15)
        {
            solved.SetActive(true);
        }
        else if (gameObject.name.Equals("puzzle16") && YandexGame.savesData.solved_16)
        {
            solved.SetActive(true);
        }
    }
}
