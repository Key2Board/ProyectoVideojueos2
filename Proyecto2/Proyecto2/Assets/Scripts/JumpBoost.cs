using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public GameObject player;
    Vector3 direction;
    public float jumpForce = 5f;

    void Update()
    {
        //generate vector in the direction of jump pad's y axis multiplied with a factor jumpForce
        direction = transform.TransformDirection(Vector3.up * jumpForce);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //applies only to objects tagged with �Player�
        {
            player = collision.gameObject;
            //apply force to the Player's rigidbody to let him "jump"
            player.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
        }
    }
}
