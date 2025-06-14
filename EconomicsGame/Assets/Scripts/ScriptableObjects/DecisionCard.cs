using UnityEngine;
[CreateAssetMenu(fileName = "New Event Card", menuName = "Event Card")]
public class EventCard : ScriptableObject
{
    public string title;
    public string description;
    public Sprite image;

    public Decision[] decisions = new Decision[3];
}

[System.Serializable]
public class Decision
{
    public string decisionText;
    public float GDPChange;
    public float publicSupportChange;
    public float currencyValueChange;
    public float corruptionChange;
    public float budgetChange;
    public float populationChange;
    public float pollutionChange;
}