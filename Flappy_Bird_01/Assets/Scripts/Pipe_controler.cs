using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Controler : MonoBehaviour
{
   public Pipe _Pipe;
    public void Inset_pipe()
    {
        float Ngau_nhien_Y = Random.Range(-3.45f, 0.9f);
        Vector2 Vi_tri_se_tao = new Vector2(3.2f, Ngau_nhien_Y);
        if (_Pipe)// NẾU VẬT CẢN CHƯA GÁN VÀO THÌ KHÔNG CHẠY
        {
            Instantiate(_Pipe, Vi_tri_se_tao, Quaternion.identity);
        }
    }
}
