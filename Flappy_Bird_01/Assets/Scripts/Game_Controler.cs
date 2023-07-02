using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        High_score = 0;

       _Pipe_Controler = FindObjectOfType<Pipe_Controler>();
        _UI = FindObjectOfType<Ui_Controler>();

       _Pipe_Controler.Inset_pipe();

    }

    // Update is called once per frame
    void Update()
    {
        if (Game_over)
        {

            _UI.Show_Score_on_Panel_Over(Score, High_score);
            _UI.setShowOrHidePanellOver(true);
           
        }
        
    }


    // Tăng điểm
    public void Plub_Score(int score)
    { 
        if(!Game_over)
        Score += score;
        if (Score >= High_score) High_score = Score;
        Debug.Log("Score: " + Score + " Hiscore:" + High_score);
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
    }
}
