using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    //methodes

    //atributs

    public CharacterController controller;

    public float vitesse;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    public Vector3 velocity;
    private Vector3 deplacements;

    public float jumpHeight = 3f;




    //deplacements = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); 

    // Start is called before the first frame update
    void Start()
    {
       // deplacements = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // velocity = velocity + gravity * Time.deltaTime;
        //deplacements = deplacements.normalized;
        deplacements = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); //la chute (y) est gérée par la velocité, produit de la gravité et deltaTime.
        deplacements = deplacements * vitesse * Time.deltaTime;
        deplacements = transform.TransformDirection(deplacements);
        controller.Move(deplacements);
        transform.Rotate(0f, Input.GetAxis("Mouse X"), 0f);

        deplacements = deplacements.normalized;
        Debug.Log(deplacements);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y = velocity.y + gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        //velocity = velocity + gravity * Time.deltaTime;



    }
}
