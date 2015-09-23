using UnityEngine;
using System.Collections;

public class enemyCreation : enemyBaseClass 
{
	private float healthMod;
	private float strMod;
	private float agiMod;
	private float iqMod;
	private float pDefMod;
	private float mDefMod;
	private float mpMod;
	private float dexMod;
	private float accMod;
	private float mdMod;

	// Race
	public void Human ()
	{
		healthMod = 1.0f;
		strMod = 1.0f;
		agiMod = 1.0f;
		iqMod = 1.0f;
		pDefMod = 1.0f;
		mDefMod = 1.0f;
		mpMod = 1.0f;
		dexMod = 1.0f;
		accMod = 1.0f;
		mdMod = 1.0f;

		accMod += 0.05f;
		agiMod += 0.05f;
		mpMod -= 0.05f;
		dexMod -= 0.05f;
		Debug.Log(dexMod);

	}
	// Gender
	public void Male ()
	{
		strMod += 0.05f;
		pDefMod += 0.05f;
		mDefMod -= 0.05f;
		dexMod -= 0.05f;
		Debug.Log(dexMod);
	}
	public void Female ()
	{
		dexMod += 0.05f;
		mDefMod += 0.05f;
		pDefMod -= 0.05f;
		strMod -= 0.05f;
		Debug.Log(dexMod);
	}
	// Class role
	public void Archer ()
	{
		accMod += 0.05f;
		dexMod += 0.05f;
		agiMod += 0.10f;
		mpMod -= 0.05f;
		pDefMod -= 0.05f;
		mDefMod -= 0.05f;
		mdMod -= 0.05f;
		Debug.Log(dexMod);
	}
	public void Soldier ()
	{
		strMod += 0.05f;
		pDefMod += 0.10f;
		mDefMod += 0.5f;
		mpMod -= 0.05f;
		dexMod -= 0.05f;
		agiMod -= 0.05f;
		mdMod -= 0.05f;
	}
	public void Mage ()
	{
		mdMod += 0.10f;
		mpMod += 0.05f;
		mDefMod += 0.5f;
		pDefMod -= 0.05f;
		strMod -= 0.05f;
		agiMod -= 0.05f;
		dexMod -= 0.05f;
	}
	public void Warrior ()
	{
		strMod += 0.15f;
		agiMod += 0.05f;
		accMod += 0.5f;
		pDefMod -= 0.10f;
		mDefMod -= 0.10f;
		mpMod -= 0.05f;
		mdMod -= 0.05f;
	}
	public void Rogue ()
	{
		agiMod += 0.10f;
		dexMod += 0.10f;
		strMod += 0.5f;
		pDefMod -= 0.10f;
		mDefMod -= 0.10f;
		healthMod -= 0.05f;
		mdMod -= 0.05f;
	}
	// Difficulty
	public void Strong ()
	{
		Debug.Log(dexMod);
		health = (int)(health * (healthMod + 0.20f));
		str = (int)(str * (strMod + 0.20f));
		agi = (int)(agi * (agiMod + 0.20f));
		iq = (int)(iq * (iqMod + 0.20));
		pDef = (int)(pDef * (pDefMod + 0.20f));
		mDef = (int)(mDef * (mDefMod + 0.20f));
		mp = (int)(mp * (mpMod + 0.20f));
		dex = (int)(dex * (dexMod + 0.20f));
		acc = (int)(acc * (accMod + 0.20f));
		md = (int)(md * (mdMod + 0.20f));
		Debug.Log(dexMod);
	}
	public void Average()
	{
		Debug.Log(dexMod);
		health = (int)(health * healthMod);
		str = (int)(str * strMod);
		agi = (int)(agi * agiMod);
		iq = (int)(iq * iqMod);
		pDef = (int)(pDef * pDefMod);
		mDef = (int)(mDef * mDefMod);
		mp = (int)(mp * mpMod);
		dex = (int)(dex * dexMod);
		acc = (int)(acc * accMod);
		md = (int)(md * mdMod);
		Debug.Log(dexMod);
	}
	public void Weak ()
	{
		Debug.Log(dexMod);
		health = (int)(health * (healthMod - 0.20f));
		str = (int)(str * (strMod - 0.20f));
		agi = (int)(agi * (agiMod - 0.20f));
		iq = (int)(iq * (iqMod - 0.20));
		pDef = (int)(pDef * (pDefMod - 0.20f));
		mDef = (int)(mDef * (mDefMod - 0.20f));
		mp = (int)(mp * (mpMod - 0.20f));
		dex = (int)(dex * (dexMod - 0.20f));
		acc = (int)(acc * (accMod - 0.20f));
		md = (int)(md * (mdMod - 0.20f));
		Debug.Log(dexMod);
	}

	/*
	public void Animal ()
	{

	}
	public void Alpha ()
	{
		
	}
	public void Alpha ()
	{
		
	}
	public void Alpha ()
	{
		
	}
	public void Alpha ()
	{
		
	}
	public void Alpha ()
	{
		
	}
	public void Alpha ()
	{
		
	}
	*/
}