using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float moving_speed;     // Vận tốc di chuyển
    Rigidbody2D ThamChieuToiNhaVat;
    public float LucNhay;
    // Start is called before the first frame update
    void Start()
    {
        LucNhay = 500;
            moving_speed = (moving_speed / 10000);
        
    }

    // Update is called once per frame
    void Update()
    {
        bool Phim_khoang_cach_duoc_nhan = Input.GetKeyDown(KeyCode.Space);
        if (Phim_khoang_cach_duoc_nhan)
        {
            ThamChieuToiNhaVat.AddForce(Vector2.up * LucNhay);
            //ThamChieuToiNhaVat.AddForce(new Vector2(0, LucNhay) , ForceMode2D.Force);
        }

        /* * KIỂM TRA XEM NGƯỜI CHƠI CÓ NHẤN PHÍM KHOẢNG CÁCH KO VÀ NHÂN VẬT CÓ
		   * CHẠM ĐẤT KHÔNG NÊU CẢ HAI TRẢ VỀ TRUE THÌ CHO PHÉP NHÂN VẬT NHẢY LÊN */
  
           
            
        
    }



    // SỰ KIỆN NHÂN VẬT CHẠM ĐẤT Và ống
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Pipe") || col.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Game over 1");
        }
    }


}
