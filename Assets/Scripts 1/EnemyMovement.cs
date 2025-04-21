using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10;
    public Vector3 direction;
    public Transform leftPoint;
    public Transform rightPoint;

    private Vector3 leftStart;
    private Vector3 rightStart;



    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.right;

        leftStart = leftPoint.position;
        rightStart = rightPoint.position;
    }


    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.x > rightStart.x)
        {
            direction = Vector3.left;
        }
        if (transform.position.x < leftStart.x)
        {
            direction = Vector3.right;
        }
    }
}