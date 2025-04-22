using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;
/*
 * Ravandi, Luca
 * 4/20/2025
 * Instructions for player speed, health, jump, damage, and move.
 */
public class Controller : MonoBehaviour
{
    public int speed = 10;
    public float jumpForce = 10;
    public int health = 99;
    private new Rigidbody rigidbody;

    public float invincibilityDuration = 2f;
    private bool isInvincible = false;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
        if (health > 100)
        {
            health = 100;
        }
    }

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

  public void Damaged()
    {
        if (!isInvincible)
        {
            health -= 15;
            GetComponent<MeshRenderer>().enabled = false;

            if (health <= 0)
            {
                SceneManager.LoadScene(2);
            }

            StartCoroutine(InvincibilityFrames());
        }
    }

    private IEnumerator InvincibilityFrames()
    {
        isInvincible = true;

        float flashTime = 0.1f;
        float elapsed = 0f;

        MeshRenderer mesh = GetComponent<MeshRenderer>(); // <- this line declares 'mesh'

        while (elapsed < invincibilityDuration)
        {
            if (mesh != null)
            {
                mesh.enabled = !mesh.enabled;
            }
            yield return new WaitForSeconds(flashTime);
            elapsed += flashTime;
        }

        if (mesh != null)
        {
            mesh.enabled = true;
        }

        isInvincible = false;
    }

}

// GetComponent<MeshRenderer>().enabled = false;
