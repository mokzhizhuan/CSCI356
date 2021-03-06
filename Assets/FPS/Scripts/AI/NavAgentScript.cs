using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavAgentScript : MonoBehaviour {
	public Transform target;
	private NavMeshAgent agent;
	Animator charAnim;

	void Start () {
		charAnim = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination( target.position ); // if the target is static
	}
	

	void Update () {
		//agent.SetDestination( target.position ); // if the target can move
		if((target.position - this.transform.position).magnitude > 3.0f) 
			charAnim.SetTrigger("run");
		else
			charAnim.SetTrigger("attack");

		//Debug.Log((target.position - agent.transform.position).magnitude); // for debugging
	}
}
