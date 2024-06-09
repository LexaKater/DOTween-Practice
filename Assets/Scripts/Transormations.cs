using DG.Tweening;
using UnityEngine;

public class Transormations : MonoBehaviour
{
    [SerializeField] private Vector3 _endPoint;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loops;

    public Vector3 EndPoint => _endPoint;
    public float Duration => _duration;
    public LoopType Loop => _loops;
    public int Repeats => _repeats;

}
