﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public GameObject owner;

	[SerializeField]
	protected GameObject bulletObj;
	[SerializeField]
	protected GameObject cursorObj;
	public GameObject CursorObj
	{
		get
		{
			return cursorObj;
		}
		set
		{
			cursorObj = value;
		}
	}
	[SerializeField]
	protected float fireDelay;
	protected float currDelay;

	[SerializeField]
	protected float chargeTime;
	public float ChargeTime
	{
		get
		{
			return chargeTime;
		}
		set
		{
			chargeTime = value;
		}
	}
	protected float currChargeTime;
	public float CurrChargeTime
	{
		get
		{
			return currChargeTime;
		}
		set
		{
			currChargeTime = value;
		}
	}

	protected Color bulletColor;
	public Color BulletColor
	{
		get
		{
			return bulletColor;
		}
		set
		{
			bulletColor = value;
		}
	}
	public int bulletColorIndex;

	[SerializeField]
	protected float speed;
	public float Speed
	{
		get
		{
			return speed;
		}
		set
		{
			speed = value;
		}
	}

	[SerializeField]
	protected float damageAmount;
	public float DamageAmount
	{
		get
		{
			return damageAmount;
		}
		set
		{
			damageAmount = value;
		}
	}

	[SerializeField]
	protected float chargeDamageAmount;
	public float ChargeDamageAmount
	{
		get
		{
			return chargeDamageAmount;
		}
		set
		{
			chargeDamageAmount = value;
		}
	}

	//fire sound
	[SerializeField]
	protected AudioClip fireClip;
	protected AudioSource fireAudio;
	[SerializeField]
	protected float fireAudioVolume;
	[SerializeField]
	protected AudioClip chargeClip;
	protected AudioSource chargeAudio;
	[SerializeField]
	protected float chargeAudioVolume;

	[SerializeField]
	protected GameObject bulletSpawnPosition;
	protected bool controllerConnected;
	public bool ControllerConnected
	{
		get
		{
			return controllerConnected;
		}
		set
		{
			controllerConnected = value;
		}
	}

	public abstract void Fire(string tag);
	public abstract void ChargeFire(string tag);
	public abstract AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float vol);
}
