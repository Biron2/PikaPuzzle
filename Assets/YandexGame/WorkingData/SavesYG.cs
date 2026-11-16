
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public bool solved_1 = false;
        public bool solved_2 = false;
        public bool solved_3 = false;
        public bool solved_4 = false;
        public bool solved_5 = false;
        public bool solved_6 = false;
        public bool solved_7 = false;
        public bool solved_8 = false;
        public bool solved_9 = false;
        public bool solved_10 = false;
        public bool solved_11 = false;
        public bool solved_12 = false;
        public bool solved_13 = false;
        public bool solved_14 = false;
        public bool solved_15 = false;
        public bool solved_16 = false;

        public bool is_sounds_changed = false;
        public float sfx = 1;
        public float music = 1;

        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива
        }
    }
}
