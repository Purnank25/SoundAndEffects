using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spwanPos = new Vector3(25,0,0);
    private float startDelay = 1;
    private float repeatRate = 1;
    private PlayerController playerControllerScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpwanObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpwanObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spwanPos, obstaclePrefab.transform.rotation);
        }

    }
}
