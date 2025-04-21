using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int speed = 10;
    public float jumpForce = 10;
    public int health = 100;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && OnGround())
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private bool OnGround()
    {
        bool onGround = false;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.2f))
        {
            onGround = true;
        }

        return onGround;
    }

}
