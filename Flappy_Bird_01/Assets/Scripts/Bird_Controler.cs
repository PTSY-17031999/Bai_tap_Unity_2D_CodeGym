using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Controler : MonoBehaviour
{
    public float moving_speed;     // Vận tốc di chuyển
    Rigidbody2D ThamChieuToiNhaVat;
    public float LucNhay;
    // Start is called before the first frame update
    void Start()
    {
        
            moving_speed = (moving_speed / 10000);
        
    }

    // Update is called once per frame
    void Update()
    {
        bool Phim_khoang_cach_duoc_nhan = Input.GetKeyDown(KeyCode.Space);
        if (Phim_khoang_cach_duoc_nhan)
        {
            transform.position += new Vector3(0, moving_speed, 0);
            //ThamChieuToiNhaVat.AddForce(Vector2.up * LucNhay);
        }

        /* * KIỂM TRA XEM NGƯỜI CHƠI CÓ NHẤN PHÍM KHOẢNG CÁCH KO VÀ NHÂN VẬT CÓ
		   * CHẠM ĐẤT KHÔNG NÊU CẢ HAI TRẢ VỀ TRUE THÌ CHO PHÉP NHÂN VẬT NHẢY LÊN */
  
           
            
        
    }



    // SỰ KIỆN NHÂN VẬT CHẠM ĐẤT
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("chạm trướng ngại vật TG, game over");
        }
    }


    //SỰ KIỆN NHÂN VẬT CHẠM VỚI VẬT CẢN
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Pipe"))
        {
            Debug.Log("chạm trướng ngại vật No TG, game over");
           
        }
    }
}
