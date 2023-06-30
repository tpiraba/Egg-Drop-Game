using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BunnyScript : MonoBehaviour
{
    // public float speed = 10f;
    
    private int score = 0;
    private int numOfLives = 3;

    public TextMeshProUGUI scoreText;

    private Rigidbody2D rb2D;
    
    public float moveSpeed;
    public float jumpForce;

    private SpriteRenderer spriteRenderer;
    public Sprite left_bunny;
    public Sprite right_bunny;

    //public SpriteRenderer lives;
    //private float jumpForce;
    //private bool isJumping;
    //private float moveHorizontal;
    //private float moveVertical;

    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>(); // rb is rigidbody on bunny
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //moveSpeed = 1f;
        //jumpForce = 60f;
        //isJumping = false;
    }



    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); // 1 is right, -1 is left, 0 is standing still
        // rb2D.velocity = new Vector2(moveHorizontal * moveSpeed, 0);

        float moveVertical = Input.GetAxisRaw("Vertical");
        //rb2D.velocity = new Vector2(0, moveVertical * jumpForce);


        // Right movement
        if(moveHorizontal > 0.1f)
        {
            spriteRenderer.sprite = right_bunny;
            rb2D.velocity = new Vector2(moveHorizontal * moveSpeed, 0);
        }

        // Left movement
        if(moveHorizontal < -0.1f)
        {
            spriteRenderer.sprite = left_bunny;
            rb2D.velocity = new Vector2(moveHorizontal * moveSpeed, 0);
        } 

        if(moveVertical > 0.1f)
        {
            rb2D.velocity = new Vector2(0, moveVertical * jumpForce);
        }





    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Egg"))
        {
            score = score + 1;
            scoreText.text = score.ToString();
            
        }

        if (other.gameObject.CompareTag("Rock"))
        {
            
            numOfLives = numOfLives - 1;

            /*
            if (score == 0)
            {
                scoreText.text = score.ToString();
            }
            else
            {
                score = score - 1;
                scoreText.text = score.ToString();
            }
            */
           
        }

        
    }

    
}
