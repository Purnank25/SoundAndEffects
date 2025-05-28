using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spwanPos = new Vector3(25,0,0);
    private float startDelay = 1;
    private float repeatRate = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpwanObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
            }
    void SpwanObstacle()
    {
        Instantiate(obstaclePrefab, spwanPos, obstaclePrefab.transform.rotation);

    }
}
