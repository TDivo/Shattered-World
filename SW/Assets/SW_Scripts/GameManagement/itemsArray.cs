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
		
		public Weapon (string name,int xp,int dmg,bool poi,bool cut)
		{
			weaponName = name;
			exp = xp;
			damage = dmg;
			poison = poi;
			bleed = cut;
		}
	}

	public Weapon ThiAnalAnihalator = new Weapon ("D ANAL ANIHALATOR",150,77,true,true);

	void Start () 
	{
	
	}

	void Update () 
	{

	}
}
