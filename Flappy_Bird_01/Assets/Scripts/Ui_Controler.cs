using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ui_Controler : MonoBehaviour
{
   public Text Score_Over;
   public Text Hight_Score;
   public Text Score_Main;
   public Image Medal;
   public GameObject Panel_Over;
   public GameObject Panel_Main;
   public GameObject Panel_Star;


    public void Show_Score_on_Panel(int _score)
    {
        if (Score_Main) Score_Main.text = _score.ToString();

    }

    public void Show_Score_on_Panel_Over(int _score, int _Hight_score)
    {
        if(Score_Over && Hight_Score)
        {
            Sprite Huy_chuong_vang =  Resources.Load <Sprite>("Assets/Image/Mobile - Flappy Bird - Version 12 Sprites_72.prefab");
            Medal.sprite = Huy_chuong_vang;
            Score_Over.text = _score.ToString();
            Hight_Score.text = _Hight_score.ToString();

        }
    }
    // Hiện thị hoặc tất Panell Kết thúc game
    public void setShowOrHidePanellOver(bool show_or_hide)
    {
        if (Panel_Over)
        {
            Debug.Log("PANELL Over SHOW");
            Panel_Over.SetActive(show_or_hide);
        }
    }

    // Hiện thị hoặc tất Panell Đang chơi game
    public void setShowOrHidePanellMain(bool show_or_hide)
    {
        if (Panel_Main)
        {
            Debug.Log("PANELL Main SHOW");
            Panel_Main.SetActive(show_or_hide);
        }
    }

    // Hiện thị hoặc tất Panell Bắt đầu chơi
    public void setShowOrHidePanellStar(bool show_or_hide)
    {
        if (Panel_Star)
        {
            Debug.Log("PANELL STAR SHOW");
            Panel_Star.SetActive(show_or_hide);
        }
    }


}
