using UnityEngine;
using UnityEngine.UI;
using YG;

public class ClickSwap : MonoBehaviour
{
    private bool solved = false;
    public bool isSelected = false;
    public static Image selectedImage;
    public AudioSource hlop;
    private Button btn;
    private Manager manager;

    [SerializeField] private ClickSwap[] clickSwaps;
    [SerializeField] private GameObject winWindow;
    [SerializeField] private CountdownTimer countdownTimer;
    private void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => ClickOnPart());
    }
    private void ClickOnPart()
    {
        if(!solved)
        {
            if (!isSelected)
            {
                if (selectedImage == null)
                {
                    isSelected = true;
                    selectedImage = GetComponent<Image>();
                    selectedImage.color = Color.red;
                }
                else
                {
                    Image currentImage = GetComponent<Image>();
                    Sprite tempSprite = selectedImage.sprite;
                    selectedImage.sprite = currentImage.sprite;
                    currentImage.sprite = tempSprite;
                    selectedImage.color = Color.white;
                    currentImage.color = Color.white;

                    isSelected = false;
                    clickSwaps[0].isSelected = false;
                    clickSwaps[1].isSelected = false;
                    clickSwaps[2].isSelected = false;
                    clickSwaps[3].isSelected = false;
                    clickSwaps[4].isSelected = false;
                    clickSwaps[5].isSelected = false;
                    clickSwaps[6].isSelected = false;
                    clickSwaps[7].isSelected = false;
                    clickSwaps[8].isSelected = false;
                    clickSwaps[9].isSelected = false;
                    clickSwaps[10].isSelected = false;
                    clickSwaps[11].isSelected = false;
                    clickSwaps[12].isSelected = false;
                    clickSwaps[13].isSelected = false;
                    clickSwaps[14].isSelected = false;
                    clickSwaps[15].isSelected = false;
                    clickSwaps[16].isSelected = false;
                    clickSwaps[17].isSelected = false;
                    selectedImage = null;
                    hlop.Play();
                }
            }
            else
            {
                isSelected = false;
                if (selectedImage != null)
                {
                    selectedImage.color = Color.white;
                    selectedImage = null;
                }
            }
        }
    }
    private void Update()
    {
        if (clickSwaps[0].GetComponent<Image>().sprite.name.Equals("1") &&
                   clickSwaps[1].GetComponent<Image>().sprite.name.Equals("2") &&
                   clickSwaps[2].GetComponent<Image>().sprite.name.Equals("3") &&
                   clickSwaps[3].GetComponent<Image>().sprite.name.Equals("4") &&
                   clickSwaps[4].GetComponent<Image>().sprite.name.Equals("5") &&
                   clickSwaps[5].GetComponent<Image>().sprite.name.Equals("6") &&
                   clickSwaps[6].GetComponent<Image>().sprite.name.Equals("7") &&
                   clickSwaps[7].GetComponent<Image>().sprite.name.Equals("8") &&
                   clickSwaps[8].GetComponent<Image>().sprite.name.Equals("9") &&
                   clickSwaps[9].GetComponent<Image>().sprite.name.Equals("10") &&
                   clickSwaps[10].GetComponent<Image>().sprite.name.Equals("11") &&
                   clickSwaps[11].GetComponent<Image>().sprite.name.Equals("12") &&
                   clickSwaps[12].GetComponent<Image>().sprite.name.Equals("13") &&
                   clickSwaps[13].GetComponent<Image>().sprite.name.Equals("14") &&
                   clickSwaps[14].GetComponent<Image>().sprite.name.Equals("15") &&
                   clickSwaps[15].GetComponent<Image>().sprite.name.Equals("16") &&
                   clickSwaps[16].GetComponent<Image>().sprite.name.Equals("17") &&
                   clickSwaps[17].GetComponent<Image>().sprite.name.Equals("18"))
        {
            countdownTimer.solvedStopTimer = true;
            winWindow.SetActive(true);
            solved = true;

            if(manager.choosenLevel == 1)
            {
                YandexGame.savesData.solved_1 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 2)
            {
                YandexGame.savesData.solved_2 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 3)
            {
                YandexGame.savesData.solved_3 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 4)
            {
                YandexGame.savesData.solved_4 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 5)
            {
                YandexGame.savesData.solved_5 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 6)
            {
                YandexGame.savesData.solved_6 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 7)
            {
                YandexGame.savesData.solved_7 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 8)
            {
                YandexGame.savesData.solved_8 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 9)
            {
                YandexGame.savesData.solved_9 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 10)
            {
                YandexGame.savesData.solved_10 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 11)
            {
                YandexGame.savesData.solved_11 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 12)
            {
                YandexGame.savesData.solved_12 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 13)
            {
                YandexGame.savesData.solved_13 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 14)
            {
                YandexGame.savesData.solved_14 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 15)
            {
                YandexGame.savesData.solved_15 = true;
                YandexGame.SaveProgress();
            }
            else if (manager.choosenLevel == 16)
            {
                YandexGame.savesData.solved_16 = true;
                YandexGame.SaveProgress();
            }
        }
    }
}