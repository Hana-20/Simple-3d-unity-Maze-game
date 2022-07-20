using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public Text timerCounnter;
    private float StartTime;
    public int TimeLimite;
    public GameObject StartScreen;
    public GameObject GameOverScreen;
    public GameObject ExitScreen;
    public GameObject Player;
    private bool gamePuse;
    public GameObject WinScreen;
    public RawImage Image;
    public Texture Black;
    public Texture red;
    // Start is called before the first frame update
    void Start()
    {
        gamePuse = true;
       
    }
    // Update is called once per frame
    void Update()
    {
        if (!gamePuse)
        {

             Player.SetActive(true);
             float Coun = TimeLimite - Time.time+StartTime;
             int Min = ((int)Coun / 60);
             float sec = (Coun % 60);
             float time = Min + sec;
             timerCounnter.text = (Min + ":" + sec.ToString("f2"));
             if (time <= 0)
             {
                 GameOver();
             }
            if (time <= 10)
            {
                timerCounnter.color = Color.red;
                Image.texture = red;
            }
            
        }
        else
        {
            Player.SetActive(false);
        }
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ExitScreen.active)
            {
                ExitScreen.SetActive(false);
                gamePuse = false;
                Time.timeScale = 1;
            }
            else
            {
                StartScreen.SetActive(false);
                GameOverScreen.SetActive(false);
                WinScreen.SetActive(false);
                ExitScreen.SetActive(true);
                Time.timeScale = 0;
                gamePuse = true;
            }
        }
        
    }
    public  void GameOver()
    {
        GameOverScreen.SetActive(true);
        Player.SetActive(false);
        gamePuse = true;
        timerCounnter.text = "0:00";

    }
    public void StartGame()
    {
        StartScreen.SetActive(false);
        Player.SetActive(true);
        StartTime = Time.time;
        timerCounnter.color = Color.white;
        Image.texture = Black;
        gamePuse = false;

    }
    
    public void EXIT()
    {
        Application.Quit();

    }
    public void PlayAgain()
    {
        StartTime = Time.time ;
        gamePuse = false;
        GameOverScreen.SetActive(false);
        WinScreen.SetActive(false);
        Player.SetActive(true);
        Player.transform.position = new Vector3(16.99f, 1.46f, 28.45f);
        timerCounnter.color = Color.white;
        Image.texture = Black;

    }
    public void Winning()
    {
        StartTime = Time.time;
        timerCounnter.text = "0:00";
        WinScreen.SetActive(true);
        gamePuse = true;

    }
    
}
