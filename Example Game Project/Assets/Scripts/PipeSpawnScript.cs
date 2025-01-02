using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;

    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {  
        // If timer is less than spawnRate add 1 to timer each second(Time.deltaTime runs each second I think)
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else // When timer is higher than spawnRate, spawn pipe and reset timer
        {
            spawnPipe();
            timer = 0;
        }
      
    }

    // Function to spawn pipes
    void spawnPipe()
    {   
        // Create variables for lowest and highest spawn point depending on heightOffset
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Spawn pipe with random Y range between the lowestPoint and highestPoint
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
