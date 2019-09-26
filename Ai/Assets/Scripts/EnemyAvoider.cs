using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]


public class EnemyAvoider : MonoBehaviour
{
    [SerializeField] EnemyVisibility visibility = null;
    [SerializeField] float searchAreaSize = 10f;
    [SerializeField] float searchCellSize=1f;
    [SerializeField] bool visualize = true;
    NavMeshAgent agent;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        agent = GetComponent<NavMeshAgent>();
        while (true)
        {
            if (visibility.targetIsVisible)
            {
                Vector3 hidingSpot;
                if (FindHidingSpot(out hidingSpot)==false))
                {
                    yield return new WaitForSeconds(1.0f);
                    continue;
                }
                agent.destination.hidingSpot;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    bool FindHidingSpot(out Vector3 hidinngSpot)
    {
        var distribution = new PoissonDiscSampler(searchAreaSize, searchAreaSize, searchCellSize);
        var candidateHidingSpots = new List<Vector3>();
        foreach (var point in distribution.Samples())
        {
            var searchPoint = point;
            searchPoint.x -= searchAreaSize / 2f;
            searchPoint.y -= searchAreaSize / 2f;
            var searchPointLocalSpace = new Vector3(searchPoint.x, transform.localPosition.y, searchPoint.y);
            var searchPointinWorldSpace = transform.TransformPoint(searchPointLocalSpace);

            NavMeshHit hit;
            bool foundPoint;

            foundPoint = NavMesh.SamplePosition(searchPointinWorldSpace,out hit, 5, NavMesh.AllAreas);

            if (foundPoint == false)
            {
                continue;
            }

            searchPointinWorldSpace = hit.position;
            var canSee = visibility.CheckVisibilityToPoint(searchPointinWorldSpace);

            if (canSee == false)
            {
                candidateHidingSpots.Add(searchPointinWorldSpace);
            }
            if (visualize)

            {
                Color debugColor = canSee ? Color.red : Color.green;
                Debug.DrawLine(transform.position, searchPointinWorldSpace, debugColor, 0, 1f);
            }
        }
        if (candidateHidingSpots == 0)
        {
            hidingSpot = Vector3.zero;
            return false;
        }

        List<KeyValuePair<Vector3, float>> paths;
        paths = candidateHidingSpots.ConvertAll((Vector3 point) =>
         {
             var path = new NavMeshPath();
             float distance;
             if (path.status != NavMeshPathStatus.PathComplete)
             {
                 distance = Mathf.Infinity;
             }
             else
             {
                 var corners = new Vector3[32];
                 var cornerCount = path.GetCornersNonAlloc(corners);
                 Vector3 current = corners[0];
                 distance = 0;
                 for (int c = 1; c < cornerCount; c++)
                 {
                     var next = corners[c];
                     distance += Vector3.Distance(current, next);
                     current = next;
                 }
             }
         });

        paths.Sort((a, b) =>
        {
            return a.Value.CompareTo(b.Value);
        });

        hidingSpot = paths[0].Key;
        return true;
    }
    }

    // Update is called once per frame
 
