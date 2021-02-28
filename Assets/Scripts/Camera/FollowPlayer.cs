using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Refers to the current transform of the object the script is located in = camera
        transform.position = player.position + offset;
    }
}
