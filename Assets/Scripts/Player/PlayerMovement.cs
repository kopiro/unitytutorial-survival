using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 6f;

	Vector3 movement;
	Animator anim;
	Rigidbody rb;

	int floorMask;
	float camRayLength = 100f;

	void Awake() {
		floorMask = LayerMask.GetMask ("Floor");
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}
			



}