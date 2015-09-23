using UnityEngine;
using System.Collections;

public class spawnEnemy : enemyCreation 
{
	public enemyRace t_Race;
	public enemyGender t_Gender;
	public enemyClass t_Class;
	public enemyDifficulty t_Difficulty;
	
	private int enemyValue;
	private int currentLevel;

	void Update () 
	{
		if (currentLevel != enemyLevel)
		{
			base.EnemyStats();

			switch(t_Race)
			{
				case(enemyRace.human):
					Human();
					SelectGender();
					break;
			}
		}
		currentLevel = enemyLevel;
	}
	void SelectGender()
	{
		switch(t_Gender)
		{
			case(enemyGender.male):
				Male();
				SelectClass();
				break;
			
			case(enemyGender.female):
				Female();
				SelectClass();
				break;
		}
	}
	void SelectClass()
	{
		switch(t_Class)
		{
			case(enemyClass.soldier):
				Soldier();
				SelectDifficulty();
				break;
			case(enemyClass.archer):
				Soldier();
				SelectDifficulty();
				break;
			case(enemyClass.rogue):
				Soldier();
				SelectDifficulty();
				break;
			case(enemyClass.mage):
				Soldier();
				SelectDifficulty();
				break;
			case(enemyClass.warrior):
				Soldier();
				SelectDifficulty();
				break;
		}
	}
	void SelectDifficulty()
	{
		switch(t_Difficulty)
		{
			case(enemyDifficulty.strong):
				Strong();
				break;
			case(enemyDifficulty.average):
				Average();
				break;
			case(enemyDifficulty.weak):
				Weak();
				break;
		}
	}
}
