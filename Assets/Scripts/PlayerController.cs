using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player character controller
    public CharacterController controller;

    //smooth rotation variables
    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;

    //game manager
    public GameManager gameManager;
    public Joystick joystick;

    public Animator animation;

    private void Start()
    {
        //animation = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (gameManager.phoneVersion == false)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
            if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
            {
                animation.SetBool("isWalking", true);

            }
            else if (Input.GetKey("a") || Input.GetKey(KeyCode.DownArrow))
            {
                animation.SetBool("isWalking", true);

            }
            else if (Input.GetKey("s") || Input.GetKey(KeyCode.RightArrow))
            {
                animation.SetBool("isWalking", true);
            }
            else if (Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow))
            {
                animation.SetBool("isWalking", true);
            }
            else
                animation.SetBool("isWalking", false);
        }
        if (gameManager.phoneVersion == true)
        {
            horizontal = joystick.Horizontal;
            vertical = joystick.Vertical;
            if (Mathf.Abs(horizontal) > 0 || Mathf.Abs(vertical) > 0)
            {
                animation.SetBool("isWalking", true);
            }
            if (Mathf.Abs(horizontal) == 0 || Mathf.Abs(vertical) == 0)
            {
                animation.SetBool("isWalking", false);
            }
        }
        /*if (Mathf.Abs(horizontal) > 0 || Mathf.Abs(vertical) > 0)
        {
            animation.SetBool("isWalking", true);
        }
        if (Mathf.Abs(horizontal) == 0 || Mathf.Abs(vertical) == 0)
        {
            animation.SetBool("isWalking", false);
        }*/
        /*if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            animation.SetBool("isWalking", true);

        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.DownArrow))
        {
            animation.SetBool("isWalking", true);

        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.RightArrow))
        {
            animation.SetBool("isWalking", true);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow))
        {
            animation.SetBool("isWalking", true);
        }
        else
            animation.SetBool("isWalking", false);*/
        

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
        direction.y -= gameManager.gravity * Time.deltaTime;
        controller.Move(direction * gameManager.playerSpeed * Time.deltaTime);
    }

}
