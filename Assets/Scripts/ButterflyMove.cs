using System.Collections;
using UnityEngine;

public class ButterflyMove : MonoBehaviour
{
    public Transform waypointParent;
    public SpriteRenderer sprite;
    public float moveSpeed = 2f;

    private Transform[] waypoints;
    private int currentWaypointIndex;
    private bool isWaiting;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waypoints = new Transform[waypointParent.childCount];
        for (int i=0; i < waypointParent.childCount; i++)
        {
            waypoints[i] = waypointParent.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveToWayPoint();
    }

    void MoveToWayPoint()
    {
        Transform target = waypoints[currentWaypointIndex];
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position)< 0.1f)
        {
           currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }


}
