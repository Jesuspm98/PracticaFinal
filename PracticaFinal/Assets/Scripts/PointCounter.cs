using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
	public int currentNumberOfPoints;
	public Text amountCounterText;

	public void Start()
	{
		amountCounterText.text = currentNumberOfPoints.ToString();
	}

	public void GetCoins(int pointAmount)
	{
		amountCounterText.text = currentNumberOfPoints.ToString();

		currentNumberOfPoints += pointAmount;
	}
}   