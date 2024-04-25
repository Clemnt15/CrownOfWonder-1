using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using UnityEngine;

public class MoveYourCube : MonoBehaviour
{
    [SerializeField] float transSpeed = 10f;

    [SerializeField] Animator playerAnimator;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] int jumpPower;

    bool isGrounded;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();



    }

    //This is a fonction to put all the translations and rotations of the cube
    void Movement()
    {
        playerAnimator.SetBool("BoolRun", false);

        if (Input.GetKey(KeyCode.RightArrow)) //Here, we ask if the Right Arrow key is push, if it is true, then, the cube go up on X axis for 0.05 per frame
        {

            transform.Translate(transSpeed * Time.deltaTime, 0, 0);
            playerAnimator.SetBool("BoolRun", true);
            spriteRenderer.flipX = false;

        }

        if (Input.GetKey(KeyCode.LeftArrow)) //Here, we ask if the Left Arrow key is push, if it is true, then, the cube go down on X axis for 0.05 per frame
        {

            transform.Translate(-transSpeed * Time.deltaTime, 0, 0);
            playerAnimator.SetBool("BoolRun", true);
            spriteRenderer.flipX = true;

        }


    }



    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            playerAnimator.SetBool("BoolJump", true);                                                             //play jump animation
        }
        else                                                                                                                           //I make sure that when I release the key, the animation ends.
        {
            playerAnimator.SetBool("BoolJump", false);
        }
    }

    
}

