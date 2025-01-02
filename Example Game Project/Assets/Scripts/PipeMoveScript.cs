using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{   
    public float moveSpeed = 1;
    public float deadZone = -5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Move pipe to the left with the speed of moveSpeed
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;

        // If pipe is past the deadZone destroy the pipe and debug to console
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); 
        }
    }
}
