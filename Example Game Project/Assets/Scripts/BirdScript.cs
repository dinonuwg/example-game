using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            // Accesses the objects rigidbody and gives it a velocity on the Y axis times 10
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

        
    }
}
