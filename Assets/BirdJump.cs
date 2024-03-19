using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Start 입니다."); /* cout */
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update 입니다.");
        if (Input.GetMouseButtonDown(0)) /* 0 : 마우스 왼쪽버튼 */
        {
            rb.velocity = Vector2.up * jumpPower;

            //var jumpforce = 3.0f;
            //float jumpforce = 3.0f;
            //rb.velocity = new Vector2(0, jumpforce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
