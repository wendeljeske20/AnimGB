using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationPanel : MonoBehaviour
{
	public Body body;

	public BlendShapeData blendShapeData;
	public Transform content;
	private void Start()
	{
		for (int i = 0; i < blendShapeData.blendShapeItems.Length; i++)
		{
			BlendShapeItem blendShapeItem = blendShapeData.blendShapeItems[i];

			Text blendShapeItemText = content.GetChild(i).GetChild(0).GetComponent<Text>();
			blendShapeItemText.text = blendShapeItem.displayText;

			Slider slider = content.GetChild(i).GetChild(1).GetComponent<Slider>();

			slider.onValueChanged.AddListener(value => ChangeBlendshapeValue(blendShapeItem.name, value));
		}
	}

	private void ChangeBlendshapeValue(string name, float value)
	{
		int index = body.mesh.GetBlendShapeIndex(name);
		body.skinnedMeshRenderer.SetBlendShapeWeight(index, value * 100);
	}
}
