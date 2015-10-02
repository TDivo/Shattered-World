using UnityEngine;
using System.Collections;

public class worldManager : MonoBehaviour 
{
	public GameObject playerCharacter;
	public float encounterRate = 10;
	public playerMovement p_Move;
	
	void Start () 
	{
		playerCharacter = GameObject.Find("Player");
		p_Move = playerCharacter.GetComponent<playerMovement>(); 
	}

	void Update () 
	{
		if (encounterRate <= 0)
		{
			Battle ();
			encounterRate = (Random.Range(5.0f,12.0f));
		}
		if (p_Move.zPoint > 0.0f || p_Move.zPoint < 0.0f)
		{
			encounterRate = (encounterRate - 1 * Time.deltaTime);
		}
		else if (p_Move.xPoint > 0.0f || p_Move.xPoint < 0.0f)
		{
			encounterRate = (encounterRate - 1 * Time.deltaTime);
		}
	}
	void Battle ()
	{
		p_Move.zPoint = 0;
		p_Move.xPoint = 0;
		p_Move.isBattling = true;
		EnemyTypes();
		p_Move.isBattling = false;
	}
	void EnemyTypes()
	{
		int enemySize = Random.Range(1,3)+1;
		int counter = enemySize;
		float nextPosX = 0.0f;
		float nextPosZ = 5.0f;

		GameObject enemyPrefab = Resources.Load("SW_EnemyPrefabs/testPrefabs/humanMaleSoldier", typeof (GameObject)) as GameObject;

		while (counter>0)
		{
			Vector3 ePos = new Vector3 (playerCharacter.transform.position.x + nextPosX,
			                            playerCharacter.transform.position.y,
			                            playerCharacter.transform.position.z + nextPosZ);
			nextPosX = nextPosX + 5.0f;
			Instantiate(enemyPrefab,ePos, Quaternion.identity);
			counter--;
		}
	}
}
