using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Operation1;

namespace Generics
{
    public class Agent : MonoBehaviour
    {
        [Header("List of destinations")]
        public List<Transform> DestinationsPath;

        private int currentDestination = 0;
        private NavMeshAgent navAgent;

        private void Awake()
        {
            //Get Components
            navAgent = GetComponent<NavMeshAgent>();

            // Position model on nav mesh
            NavMeshHit closestHit;

            if (NavMesh.SamplePosition(transform.position, out closestHit, 500f, NavMesh.AllAreas))
                transform.position = closestHit.position;
            else
                Debug.LogError("Could not find position on NavMesh!");
        }

        public NavMeshAgent GetNavMeshAgent()
        {
            return navAgent;
        }
        public bool CheckDestinationArrival()
        {
            if (Vector3.Distance(transform.position, DestinationsPath[currentDestination].position) < 1f)
                return true;
            return false;
        }
        public void MoveTo(Vector3 target)
        {
            navAgent.SetDestination(target);
        }
        public void MoveToNextDestination()
        {
            if (currentDestination == DestinationsPath.Count - 1)
                currentDestination = 0;
            else
            {
                currentDestination++;
            }
            navAgent.SetDestination(DestinationsPath[currentDestination].position);
        }
        public void RotateTowards(Transform target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 2);
        }
    }

}
