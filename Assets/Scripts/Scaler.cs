using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _newScale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loops;

    private void Start() => transform.DOScale(_newScale, _duration).SetLoops(_repeats, _loops);
}
