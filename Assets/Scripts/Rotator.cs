using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotatePoints;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loops;

    private void Start() => transform.DORotate(_rotatePoints, _duration).SetLoops(_repeats, _loops);
}
