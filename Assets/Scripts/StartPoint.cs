using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    private PlayerController player;

    [SerializeField] private Vector2 facingDirection;

    public string uuid; //Universal Unique Identifier

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if (!player.nextUuid.Equals(uuid))
        {
            return;
        }
        player.transform.position = transform.position;

        player.lastDirection = facingDirection;
        GameObject confiner = GameObject.Find("Confiner");
        if (confiner != null)
        {
            //GetComponent<CinemachineConfiner2D>().#CinemachineConfiner2D;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
