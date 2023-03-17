using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
  [SerializeField] float turnSpeed = 100;
  [SerializeField] float moveSpeed = 5;
  [SerializeField] float slowSpeed = 15f;
  [SerializeField] float boostSpeed = 30f;


  void Start()
  {
    Debug.Log("gaco");
  }

  void Update()
  {
    float turnDirection = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
    float moveDirection = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    transform.Rotate(0, 0, -turnDirection);
    transform.Translate(0, moveDirection, 0);
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    moveSpeed = slowSpeed;
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Boost")
    {
      moveSpeed = boostSpeed;
    }
  }


}
