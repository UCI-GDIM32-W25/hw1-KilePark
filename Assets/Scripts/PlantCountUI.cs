using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    public static PlantCountUI instance;

    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _numSeedsLeft = 5;
        _numSeedsPlanted = 0;

        _plantedText.text = "Seeds Remaining: " + _numSeedsLeft.ToString();
        _remainingText.text = "Seeds Planted: " + _numSeedsPlanted.ToString();
    }

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _numSeedsLeft -= seedsLeft;
        _numSeedsPlanted += seedsPlanted;

        _plantedText.text = "Seeds Remaining: " + _numSeedsLeft.ToString();
        _remainingText.text = "Seeds Planted: " + _numSeedsPlanted.ToString();
    }
}