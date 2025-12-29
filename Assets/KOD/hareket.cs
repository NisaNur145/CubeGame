using UnityEngine;
using UnityEngine.SceneManagement; 

public class hareket : MonoBehaviour
{
   [SerializeField]
   private float moveSpeed=5f;
   Rigidbody rb;
    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveHorizontal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");
        Vector3 movement=new Vector3(moveHorizontal,0,moveVertical)*moveSpeed;
        rb.linearVelocity=movement;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("oyun biti");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
