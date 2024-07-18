using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] AudioSource jumpSound;

        public Vector3 jump;
        public float jumpForce = 5f;
        public bool isGrounded;
        public Rigidbody rb;
        public float moveSpeed = 3f;
        private float xInput;
        private float zInput;
    public Transform teleportDestination;


        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            jump = new Vector3(0.0f, 3f, 0.0f);
        }

        void OnCollisionStay()
        {
            isGrounded = true;
        }
        void OnCollisionExit()
        {
            isGrounded = false;
        }

        void Update()
        {
            ProcessInputs();
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                jumpSound.Play();
                isGrounded = false;
            }
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void ProcessInputs()
        {
            xInput = Input.GetAxis("Horizontal");
            zInput = Input.GetAxis("Vertical");
        }

        private void Move()
        {
            rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
        }

    void OnTriggerEnter(Collider _c)
    {
        if(_c.gameObject.tag == "teleport")
        {
            transform.position = teleportDestination.position;
        }
    }





}

/*public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] AudioSource jumpSound;
    // Start is called before the first frame update
    public Vector3 jump;
    public float jumpForce = 5f;
    public bool isGrounded;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.035f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.035f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.0f, 0f, -0.035f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.0f, 0f, 0.035f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            jumpSound.Play();
            isGrounded = false;
        }
    }

public Rigidbody rb;
public float moveSpeed = 3f;
private float xInput;
private float zInput;

void Awake()
{
    rb = GetComponent<Rigidbody>();
    jump = new Vector3(0.0f, 3f, 0.0f);
}

void OnCollisionStay()
{
    isGrounded = true;
}
void OnCollisionExit()
{
    isGrounded = false;
}

void Update()
{
    ProcessInputs();
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
    {
        rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        jumpSound.Play();
        isGrounded = false;
    }
}

private void FixedUpdate()
{
    Move();
}

private void ProcessInputs()
{
    xInput = Input.GetAxis("Horizontal");
    zInput = Input.GetAxis("Vertical");
}

private void Move()
{
    rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
}*/




