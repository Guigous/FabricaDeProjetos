﻿using UnityEngine;

namespace Cinemachine.Examples
{

[AddComponentMenu("")] // Don't display in add component menu
public class CharacterMovement : MonoBehaviour
{
    public bool useCharacterForward = false;
    public float turnSpeed = 10f;
    public KeyCode sprintJoystick = KeyCode.JoystickButton2;
    public KeyCode sprintKeyboard = KeyCode.LeftShift;
    public KeyCode jumpKeyboard = KeyCode.Space;
    public float jumpForce;
    public GameObject grdCheck;
        public LayerMask ground;
    

        //Raycast Settings
        RaycastHit hit;
        public float maxDistance;
        bool isHiting;
        public float radius;

    private float turnSpeedMultiplier;
    private float speed = 0f;
    private float direction = 0f;
    private bool isSprinting = false;
    private bool isJumping = false;
    private Rigidbody rb;
    
    
    private Animator anim;
    private Vector3 targetDirection;
    private Vector2 input;
    private Quaternion freeRotation;
    private Camera mainCamera;
    private float velocity;

	// Use this for initialization
	void Start ()
	{
	    anim = GetComponent<Animator>();
	    mainCamera = Camera.main;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    input.x = Input.GetAxis("Horizontal");
	    input.y = Input.GetAxis("Vertical");

        Grounded();
            //isHiting = Physics.SphereCast(transform.position, transform.localScale.x / radius, Vector3.down, out hit, maxDistance);
            isHiting = Physics.Raycast(transform.position, Vector3.down,out hit,maxDistance);

            // set speed to both vertical and horizontal inputs
        if (useCharacterForward) 
          speed = Mathf.Abs(input.x) + input.y;
        else 
          speed = Mathf.Abs(input.x) + Mathf.Abs(input.y);

          speed = Mathf.Clamp(speed, 0f, 1f);
          speed = Mathf.SmoothDamp(anim.GetFloat("Speed"), speed, ref velocity, 0.1f);
        
        anim.SetFloat("Speed", speed);

	    if (input.y < 0f && useCharacterForward) 
            direction = input.y;
	    else 
            direction = 0f;
        
        anim.SetFloat("Direction", direction);

            //Set Jump
            isJumping = (Input.GetKey(jumpKeyboard));
            anim.SetBool("isJumping", isJumping);
        

        // set sprinting
        isSprinting = ((Input.GetKey(sprintJoystick) || Input.GetKey(sprintKeyboard)) && input != Vector2.zero && direction >= 0f);
        anim.SetBool("IsSprinting", isSprinting);

        

            // Update target direction relative to the camera view (or not if the Keep Direction option is checked)
            UpdateTargetDirection();

            if (input != Vector2.zero && targetDirection.magnitude > 0.1f)
        {
            Vector3 lookDirection = targetDirection.normalized;
            freeRotation = Quaternion.LookRotation(lookDirection, transform.up);
            var diferenceRotation = freeRotation.eulerAngles.y - transform.eulerAngles.y;
            var eulerY = transform.eulerAngles.y;

            if (diferenceRotation < 0 || diferenceRotation > 0) eulerY = freeRotation.eulerAngles.y;
            var euler = new Vector3(0, eulerY, 0);

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(euler), turnSpeed * turnSpeedMultiplier * Time.deltaTime);
        }
	}

        public void Update()
        {
            if (Input.GetKeyDown(jumpKeyboard) && isHiting == true)
            {
                //rb.AddForce(1, 1*jumpForce, 1);
                anim.SetBool("isJumping", true);
                
            }
            if(isHiting == false)
            {
                anim.SetBool("isJumping", false);
            }

        }

        private bool isGrounded;

        public void Grounded()
        {
            if(isHiting)
            {
                isGrounded = true;
                Debug.Log("Grounded");

            }
            else
            {
                isGrounded = false;
                Debug.Log("Not Grounded");
            }
        }

        private void OnDrawGizmos()
        {
            if (isHiting)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawRay(transform.position, Vector3.down * maxDistance);
                //Gizmos.DrawWireSphere(transform.position + (Vector3.down * hit.distance), transform.localScale.x / radius);
                print(hit.collider.name);
            }
            else
            {
                Gizmos.color = Color.green;
                Gizmos.DrawRay(transform.position, Vector3.down * maxDistance);
            }
        }
        
        public virtual void UpdateTargetDirection()
    {
        if (!useCharacterForward)
        {
            turnSpeedMultiplier = 1f;
            var forward = mainCamera.transform.TransformDirection(Vector3.forward);
            forward.y = 0;

            //get the right-facing direction of the referenceTransform
            var right = mainCamera.transform.TransformDirection(Vector3.right);

            // determine the direction the player will face based on input and the referenceTransform's right and forward directions
            targetDirection = input.x * right + input.y * forward;
        }
        else
        {
            turnSpeedMultiplier = 0.2f;
            var forward = transform.TransformDirection(Vector3.forward);
            forward.y = 0;

            //get the right-facing direction of the referenceTransform
            var right = transform.TransformDirection(Vector3.right);
            targetDirection = input.x * right + Mathf.Abs(input.y) * forward;
        }
    }
}

}
