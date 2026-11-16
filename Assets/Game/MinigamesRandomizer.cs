using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinigamesRandomizer : MonoBehaviour
{
    [SerializeField] private Image[] containers;
    [SerializeField] private Sprite[] sprites1, sprites2, sprites3, sprites4, sprites5, sprites6, sprites7,
        sprites8, sprites9, sprites10, sprites11, sprites12, sprites13, sprites14, sprites15, sprites16;
    private Manager manager;
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        ShuffleSprites();
    }

    void ShuffleSprites()
    {
        if (manager.choosenLevel == 1)
        {
            if (containers.Length != sprites1.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites1.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites1[spriteIndexes[i]];
            }
        }
        else if(manager.choosenLevel == 2)
        {
            if (containers.Length != sprites2.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites2.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites2[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 3)
        {
            if (containers.Length != sprites3.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites3.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites3[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 4)
        {
            if (containers.Length != sprites4.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites4.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites4[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 5)
        {
            if (containers.Length != sprites5.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites5.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites5[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 6)
        {
            if (containers.Length != sprites6.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites6.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites6[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 7)
        {
            if (containers.Length != sprites7.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites7.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites7[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 8)
        {
            if (containers.Length != sprites8.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites8.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites8[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 9)
        {
            if (containers.Length != sprites9.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites9.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites9[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 10)
        {
            if (containers.Length != sprites10.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites10.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites10[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 11)
        {
            if (containers.Length != sprites11.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites11.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites11[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 12)
        {
            if (containers.Length != sprites12.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites12.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites12[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 13)
        {
            if (containers.Length != sprites13.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites13.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites13[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 14)
        {
            if (containers.Length != sprites14.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites14.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites14[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 15)
        {
            if (containers.Length != sprites15.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites15.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites15[spriteIndexes[i]];
            }
        }
        else if (manager.choosenLevel == 16)
        {
            if (containers.Length != sprites16.Length)
            {
                Debug.LogError("The number of containers and sprites must be the same.");
                return;
            }

            // Создаем список индексов спрайтов
            List<int> spriteIndexes = new List<int>();
            for (int i = 0; i < sprites16.Length; i++)
            {
                spriteIndexes.Add(i);
            }

            // Перемешиваем список индексов спрайтов
            for (int i = 0; i < spriteIndexes.Count; i++)
            {
                int randomIndex = Random.Range(i, spriteIndexes.Count);
                int temp = spriteIndexes[i];
                spriteIndexes[i] = spriteIndexes[randomIndex];
                spriteIndexes[randomIndex] = temp;
            }

            // Устанавливаем спрайты на рандомные контейнеры
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].sprite = sprites16[spriteIndexes[i]];
            }
        }
    }
    public void backTOhome()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        AudioListener.pause = true;
        Time.timeScale = 0;
    }
    public void unPause()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
    }
    public void DestroyManager()
    {
        Destroy(manager.gameObject);
    }
}