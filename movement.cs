using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{
     public float speed = 1.0f;
    // public Transform target;
    // public Transform cylPosition;

     public GameObject target;
   // private NavMeshPath path;
   // private float elapsed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
       // path = new NavMeshPath();
       // elapsed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1f * Time.deltaTime);
        //elapsed += Time.deltaTime;
       // if (elapsed > 1.0f)
       // {
         //   elapsed -= 1.0f;
           // NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
       // }
        //for (int i = 0; i < path.corners.Length - 1; i++)
            //Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red);
    }
}
