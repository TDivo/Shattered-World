using UnityEngine;
using System.Collections;

public class spawnEnemy : enemyBaseClass 
{
	public enemyType t_Type;
	private int enemyValue;
	private int currentLevel;
	
	void Update () 
	{
		if (currentLevel != enemyLevel)
		{
			base.EnemyStats();

			switch(t_Type)
			{
				case(enemyType.Wolf):
					typeWolf();
					break;
			}
		}
		currentLevel = enemyLevel;
	}
}
