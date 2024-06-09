using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loops;

    private void Start() => transform.DOMove(_direction, _duration).SetLoops(_repeats, _loops);
}
