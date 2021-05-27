using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public CharacterController controller;
    public NavMeshAgent agent;
    public float speed = 5.0f;
    public Transform point1;
    public Transform lowerBound, upperBound;// point2;

    public float time;
    bool isWorking;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!isWorking)
        {
            StartCoroutine(Coroutine());
        }
    }

    Vector3 getRandomPos()
    {
        float x = Random.Range(lowerBound.position.x, upperBound.position.x);
        float z = Random.Range(lowerBound.position.z, upperBound.position.z);

        Vector3 pos = new Vector3(x, transform.position.y, z);
        return pos;
       
    }

    IEnumerator Coroutine()
    {
        isWorking = true;
        GetNewDestination();
        yield return new WaitForSeconds(time);
        isWorking = false;
    }

    void GetNewDestination()
    {
        agent.SetDestination(getRandomPos());

        if (Vector3.Distance(controller.transform.position, agent.transform.position) < 5)
        {
            agent.speed = 10f;
            agent.SetDestination(point1.position);

        }
    }
}
