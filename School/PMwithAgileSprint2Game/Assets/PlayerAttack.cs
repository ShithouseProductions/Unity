using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject shootPoint;
	public ParticleSystem shot;

	public int maxHealth = 10;
	private int currentHealth;

	private void Start()
	{
		currentHealth = maxHealth;
	}


	private void Update()
	{
		Shoot();
		DetermineSide();
		Die();
	}

	void DetermineSide ()
	{
		float x = Input.GetAxis("Horizontal");

		if (x > 0) shootPoint.transform.rotation = Quaternion.Euler(0, 0, 0);

		else if (x < 0) shootPoint.transform.rotation = Quaternion.Euler(0, 0, -180);
	}
	void Shoot()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			shot.Emit(1);
		}
	}

	public void PlayerReceiveDamage (int dmg)
	{
		currentHealth -= dmg;
	}
	private void Die()
	{
		if (currentHealth <= 0)
		{
			Debug.Log("You Died");
			//SceneManager.LoadScene(3);
		}
	}

}
