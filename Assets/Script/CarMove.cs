using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(speed * transform.up * -1 * Time.deltaTime);
    }
}
