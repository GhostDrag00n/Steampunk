using UnityEngine;
using UnityEngine.AI;
public class AIController : MonoBehaviour {

    public GameObject player;
    public float AttackDamage = 10f;
    public float health = 100f;
    public float lookRadius = 10f;
    public float awareRadius = 1f;
    NavMeshAgent agent;

	void Start () 
    {
        agent = GetComponent<NavMeshAgent>();
	}
	
	void Update () 
    {
        RaycastHit hit;
        if (Vector3.Distance(player.transform.position, this.transform.position) <= lookRadius && Physics.Raycast(this.transform.position, player.transform.position, out hit, lookRadius))
        {
            agent.SetDestination(player.transform.position);
            Attack();
        }
	}

    void Attack()
    {
        if (Vector3.Distance(player.transform.position, this.transform.position) <= awareRadius)
        {
            player.GetComponent<PlayerController>().health -= AttackDamage;
        }
    }

}
