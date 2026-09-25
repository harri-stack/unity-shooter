using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Dronemovement : MonoBehaviour
{
    public Transform Player;
    public float maxHeight = 8f;
    public float minHeight = 0f;
    public float Speed = 5f;
    public float rotationSpeed = 5f;
    public float randomRadius = 5f;
    private Vector3 randomPos;
    private bool firstTime = false;

    private void Update()
    {
        if (Player == null) return;
        Vector3 targetDirection = Player.position - transform.position;
        if (targetDirection != Vector3.zero)
        {
            Quaternion droneRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, droneRotation, Speed * Time.deltaTime);

        }

        if (firstTime == false)
        {
            firstTime = true;
            PickNewTarget();
        }

        transform.position = Vector3.MoveTowards(transform.position, randomPos, Speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, randomPos) < 0.5f)
        {
            PickNewTarget();
        }
    }

    private void PickNewTarget()
    {
        randomPos = Player.position + new Vector3(Random.Range(-randomRadius, randomRadius), Random.Range(minHeight, maxHeight), Random.Range(-randomRadius, randomRadius));
    }

}