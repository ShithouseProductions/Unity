using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 0;
	//public Collider detect = null;
	private Vector2 direction;

    private GameObject player;
	private Rigidbody rb;

	private float timer = 0;
	public float directionChangeInterval = 1f;

	private bool chase = false;
	public float chasingStep = 1f;
	[Space]
	public int maxHealth = 10;
	public int dmgReceived = 1;
	public int dmgDealed = 1;
	private int currectHealth;

	private void Start()
	{
		currectHealth = maxHealth;
		player = GameObject.FindGameObjectWithTag("Player");
		rb = GetComponent<Rigidbody>();
		direction = Vector2.left;

	}

	private void Update()
	{
		FlipDirection();
		CheckDeath();
	}

	private void FixedUpdate()
	{
		Movement();
	}



	void FlipDirection ()
	{
		timer -= Time.deltaTime;

		if (timer < 0)
		{
			direction *= -1f;
			timer = directionChangeInterval;
		}
	}

	void Movement()
	{
		if (!chase)
			rb.velocity = direction * moveSpeed;

		else
			transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * chasingStep);
	}

	void CheckDeath ()
	{
		if (currectHealth <= 0)
		{
			print("enemy died");
			gameObject.SetActive(false);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			print("I see the player!");
			chase = true;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			player.GetComponent<PlayerAttack>().PlayerReceiveDamage(dmgDealed);
			gameObject.SetActive(false);
			
		}
	}

	private void OnParticleCollision(GameObject other)
	{
		print("aahhhh!!");
		currectHealth -= dmgReceived;
	}
}
