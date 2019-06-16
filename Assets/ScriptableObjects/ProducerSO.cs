using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Team", menuName = "Team")]
public class ProducerSO : ScriptableObject
{
    public List<DeveloperData> team;
}

[Serializable]
public class DeveloperData
{
	public string name;
	public string role;
	public Sprite photo;
}