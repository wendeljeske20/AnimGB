using UnityEngine;

[CreateAssetMenu(fileName = "BlendShapeData", menuName = "BlendShapeData")]
public class BlendShapeData : ScriptableObject
{
	public BlendShapeItem[] blendShapeItems;
}

[System.Serializable]
public class BlendShapeItem
{
	public string displayText;
	public string name;
}
