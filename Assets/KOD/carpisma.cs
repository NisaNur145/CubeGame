using UnityEngine;

public class carpisma : MonoBehaviour
{
    [SerializeField]
    private int hasarmik;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
          collision.gameObject.GetComponent<HealthController>().healthController(hasarmik);
        }
    }
    
}
