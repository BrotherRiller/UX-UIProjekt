using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationRecruit : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] GameObject corpse;

    public float radius;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnMouseDown()
    {
        Instantiate(corpse, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(GetPoint.Instance.GetRandomPoint(transform, radius));
        }
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

#endif
}
