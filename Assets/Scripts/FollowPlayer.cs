using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        var pos = player.transform.position;
        transform.position = new Vector3(pos.x, pos.y + 12, pos.z - 30);
    }
}
