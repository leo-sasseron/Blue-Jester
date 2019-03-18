using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPrefab;

    [System.Serializable]
	public class PlayerStats {
		public int Health = 100;
	}

	public PlayerStats playerStats = new PlayerStats();

	public int fallBoundary = -20;

	void Update () {
		if (transform.position.y <= fallBoundary)
			DamagePlayer (9999999);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

	public void DamagePlayer (int damage) {
		playerStats.Health -= damage;
		if (playerStats.Health <= 0) {
			GameMaster.KillPlayer(this);
		}
	}
    
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
