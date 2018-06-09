using UnityEngine;
using System.Collections;

public class ArrowNPCMovement : MonoBehaviour {
	public GameObject targetGo;
	private UnityEngine.AI.NavMeshAgent navMeshAgent;
	
	void Start()
	{
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	private void Update()
	{
		HeadForDestintation();
	}

	private void HeadForDestintation ()
	{
		Vector3 destinaton = targetGo.transform.position;
		navMeshAgent.SetDestination (destinaton);
		
		// show yellow line from source to target
		UsefulFunctions.DebugRay(transform.position, destinaton, Color.yellow);
	}
}


