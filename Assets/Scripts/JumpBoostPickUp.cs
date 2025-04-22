using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostPickup : MonoBehaviour
{
    public float boostedJumpForce = 18f; // new jump force (doubled)
    public bool isTemporary = true;      
    public float boostDuration = 2f;     // duration in seconds

    public float rotSpeed = 1;

    private void Update()
    {
        transform.Rotate(0, rotSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Controller player = other.GetComponent<Controller>();
        if (player != null)
        {
            float originalJumpForce = player.jumpForce;

            player.jumpForce = boostedJumpForce;
            Debug.Log("Jump force increased to: " + boostedJumpForce);

            if (isTemporary)
            {
                StartCoroutine(ResetJumpForce(player, originalJumpForce));
            }

            Destroy(gameObject); 
        }
    }

    private IEnumerator ResetJumpForce(Controller player, float originalJumpForce)
    {
        yield return new WaitForSeconds(boostDuration);
        player.jumpForce = originalJumpForce;
        Debug.Log("Jump force reverted to: " + originalJumpForce);
    }
}


