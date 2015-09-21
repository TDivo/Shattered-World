using UnityEngine;
using System.Collections;

public class enemyBaseClass : MonoBehaviour 
{
	public enemyType e_Type;

	public int 
	health,
	str,
	agi,
	iq,
	pDef,
	mDef,
	magP,
	end,
	enemyLevel;

	public void Start () 
	{

	}
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
			magP = tempPoints + 5;
			end = tempPoints + 5;
		}
		else 
		{

		}
	}
	public enum enemyType
	{
		Wolf,
		Mage,
		Soldier,
		Theif,
		Assasin
	}
	public void typeWolf()
	{
		health = (int)(health * .80f);
		str = (int) (str * 1.10f);
		agi = (int) (agi * 1.70f);
		iq = (int) (iq * .80f);
		pDef = (int) (pDef * 1.10f);
		mDef = (int) (mDef * .90f);
		magP = (int) (magP * .50f);
	}
}
