using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControl : MonoBehaviour
{

    public float waldkspeed = 5f;
    public float jumHeight = 1.9f;
    public float gravedad = -20f;
    Vector3 moveinput = Vector3.zero;
    CharacterController characterController;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();

    }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            moveinput.z = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveinput.z = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveinput.x = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveinput.x = -1;
        }
        Move(moveinput);
        moveinput.y += gravedad * Time.deltaTime;
        characterController.Move(moveinput * Time.deltaTime);
    }
    void Move (Vector3 direction)
    {
        transform.position += direction.normalized * waldkspeed * Time.deltaTime;
    }
    



}
