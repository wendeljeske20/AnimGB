using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	Rigidbody rb;
	public float speed;
	public Vector3 velocity;
	Animator animator;
	private void Start()
	{
		rb = GetComponentInChildren<Rigidbody>();
		animator = GetComponent<Animator>();
	}
	private void Update()
	{

		if(Input.GetKey(KeyCode.D))
		rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);


	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Rock"))
		{
			animator.SetBool("Pushing", true);
		}
		else if (other.CompareTag("Jump"))
		{
			animator.SetTrigger("Jump");
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Rock"))
		{
			animator.SetBool("Pushing", false);
		}
	}

	public void SetPosition()
	{
		transform.position = transform.GetChild(1).position;
	}
}
