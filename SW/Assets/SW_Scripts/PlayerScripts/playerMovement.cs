using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour 
{
	public float xPoint = 1.0f;
	public float zPoint = 1.0f;
	public float yPoint = 0.0f;
	public float currentSpeed = 5.0f;
	public float currentGravity = 100.0f;

	public GameObject tempChar;

	public Vector3 charRotation = Vector3.zero;

	CharacterController playerController;

	private Vector3 direction = Vector3.zero;

	void Start () 
	{
		tempChar = GameObject.Find ("Character");
		playerController = GetComponent<CharacterController>(); 
	}

	void Update () 
	{
		Debug.DrawRay(tempChar.transform.position, tempChar.transform.TransformDirection(Vector3.forward), Color.red);
		if (playerController.isGrounded)
		{
			yPoint = transform.position.y;
			xPoint = CalculateRotation(Input.GetAxis("Horizontal"));
			zPoint = CalculateRotation(Input.GetAxis("Vertical"));
			charRotation = new Vector3(xPoint + transform.position.x,yPoint,zPoint + transform.position.z);

			direction = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
			direction = transform.TransformDirection(direction);
			direction *= currentSpeed;
		}
		direction.y -= currentGravity * Time.deltaTime;
		playerController.Move(direction * Time.deltaTime);
		tempChar.transform.LookAt(charRotation);
		tempChar.transform.eulerAngles = new Vector3 (0.0f,tempChar.transform.eulerAngles.y,0.0f);

		RaycastHit objHit;
		if (Physics.Raycast(tempChar.transform.position,tempChar.transform.TransformDirection(Vector3.forward), out objHit, 1.0f))
		{
			if (Input.GetKeyDown("e"))
			{
				if (objHit.collider.tag == "Action")
				{
					Debug.Log("Hit");
				}
			}
		}
	}

	float CalculateRotation(float point)
	{
		float c = point/1.0f;

		return c;
	}
}
