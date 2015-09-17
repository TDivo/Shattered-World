using UnityEngine;
using System.Collections;

public class itemsArray : MonoBehaviour 
{
	public class Weapon
	{
		public string weaponName;

		public int exp;
		public int damage;
		public bool poison;
		public bool bleed;
		
		public Weapon (int xp,int dmg,bool poi,bool cut)
		{
			exp = xp;
			damage = dmg;
			poison = poi;
			bleed = cut;
		}
	}
	public Weapon currentWep = new Weapon (36,16,false,true);

	void Start () 
	{
	
	}

	void Update () 
	{
		//currentWepHealth = currentHealth - currentWep.damage;
	}
}
