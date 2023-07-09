using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Controler : MonoBehaviour
{
    int Score; //Lưu điểm
    int High_score;  //Lưu điểm cao nhất
    Pipe_Controler _Pipe_Controler;
    Ui_Controler _UI;
    bool Game_over; //Kiểm tra game over

    

    void Start()
    {
        Game_over = false; // Set game over false để chưa kết thúc game
        Score = 0;

       _Pipe_Controler = FindObjectOfType<Pipe_Controler>();
        _UI = FindObjectOfType<Ui_Controler>();
       _Pipe_Controler.Inset_pipe();


        int birdIdPicked = PlayerPrefs.GetInt("Bird");
        // do vang cam
        // sinh ra con chim ay
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
         High_score = PlayerPrefs.GetInt("High_score"); 
        _UI.Show_Score_on_Panel_Over(Score, High_score);
        _UI.setShowOrHidePanellOver(true);
    }

    // Tăng điểm
    public void Plub_Score(int score)
    {
        if (!Game_over)
            Score += score;
        if (Score >= High_score)
        {
            High_score = Score;
            PlayerPrefs.SetInt("High_score", High_score); // Lưu điểm cao nhất vào file ghi lại
            //int value = PlayerPrefs.GetInt("High_score"); câu lệnh lấy điểm ra
        }

        _UI.Show_Score_on_Panel(Score);
    }

    // Trả về điểm số
    public int Get_Score()
    {
        return Score;
    }

    // Trả về điểm cao nhất
    public int Get_High_Score()
    {
        return High_score;
    }

    public bool Get_Over_Game()
    {
        return Game_over;
    }
    public void Set_Over_Game(bool _Over_game)
    {
        Game_over = _Over_game;
        if (Game_over == true)
        {
            GameOver();
        }
    }

    public void Play_Again()
    {
        SceneManager.LoadScene("Scene_1");
    }

    bool _Pause = false;
    public void Pause_game()
    {
        if (_Pause)
        {
            _Pause = false;
        }else _Pause = true;

        
    }
    public bool Get_Pause_Game()
    {
        return _Pause;
    }
}
