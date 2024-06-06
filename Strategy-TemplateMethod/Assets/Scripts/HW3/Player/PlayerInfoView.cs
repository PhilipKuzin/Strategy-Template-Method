using TMPro;
using UnityEngine;

public class PlayerInfoView : MonoBehaviour
{
    [SerializeField] private TMP_Text _reputationIndex;

    public void ShowReputation(int reputation)
    {
        _reputationIndex.text = reputation.ToString();
    }
}
