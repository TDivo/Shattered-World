using UnityEngine;
using System.Collections;

public class enemyBaseClass : MonoBehaviour 
{
	//public enemyType e_Type;

	public int 
	health,
	str,
	md,
	dex,
	agi,
	iq,
	pDef,
	mDef,
	mp,
	acc,
	enemyLevel;

	public void EnemyStats ()
	{
		int tempPoints = enemyLevel * 2;
		if (enemyLevel > 0)
		{
			health = (tempPoints * 50) + 25;
			str = tempPoints + 5;
			agi = tempPoints + 5;
			iq = tempPoints + 5;
			pDef = tempPoints + 5;
			mDef = tempPoints + 5;
			mp = tempPoints + 5;
			dex = tempPoints + 5;
			acc = tempPoints + 5;
			md = tempPoints + 5;
		}
		else 
		{

		}
	}
	public enum enemyRace
	{
		human,
		animal
	}
	public enum enemyGender
	{
		male,
		female
	}
	public enum enemyClass
	{
		archer,
		soldier,
		mage,
		warrior,
		rogue,
	}
	public enum enemyDifficulty
	{
		strong,
		average,
		weak
	}
	/*public void typeWolf()
	{
		health = (int)(health * .80f);
		str = (int) (str * 1.10f);
		agi = (int) (agi * 1.70f);
		iq = (int) (iq * .80f);
		pDef = (int) (pDef * 1.10f);
		mDef = (int) (mDef * .90f);
		mp = (int) (mp * .50f);
	}*/
}
