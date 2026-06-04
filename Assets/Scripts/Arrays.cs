using UnityEngine;

[CreateAssetMenu(fileName = "Arrays", menuName = "Scriptable Objects/Arrays")]
public class Arrays : ScriptableObject
{
    public GameObject[] packages = new GameObject[3];
    public GameObject[] deliveryPoints = new GameObject[3];
}
