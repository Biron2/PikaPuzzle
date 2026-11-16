using UnityEngine;
using YG;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int choosenLevel = 1;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void Level1()
    {
        choosenLevel = 1;
        LastMethod();
    }
    public void Level2()
    {
        choosenLevel = 2;
        LastMethod();
    }
    public void Level3()
    {
        choosenLevel = 3;
        LastMethod();
    }
    public void Level4()
    {
        choosenLevel = 4;
        LastMethod();
    }
    public void Level5()
    {
        choosenLevel = 5;
        LastMethod();
    }
    public void Level6()
    {
        choosenLevel = 6;
        LastMethod();
    }
    public void Level7()
    {
        choosenLevel = 7;
        LastMethod();
    }
    public void Level8()
    {
        choosenLevel = 8;
        LastMethod();
    }
    public void Level9()
    {
        choosenLevel = 9;
        LastMethod();
    }
    public void Level10()
    {
        choosenLevel = 10;
        LastMethod();
    }
    public void Level11()
    {
        choosenLevel = 11;
        LastMethod();
    }
    public void Level12()
    {
        choosenLevel = 12;
        LastMethod();
    }
    public void Level13()
    {
        choosenLevel = 13;
        LastMethod();
    }
    public void Level14()
    {
        choosenLevel = 14;
        LastMethod();
    }
    public void Level15()
    {
        choosenLevel = 15;
        LastMethod();
    }
    public void Level16()
    {
        choosenLevel = 16;
        LastMethod();
    }
    private void LastMethod()
    {
        SceneManager.LoadScene("Game");
    }
}
