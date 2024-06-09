using UnityEngine;
using DG.Tweening;

public class Colorist : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loops;

    private void Start() => _renderer.DOColor(_color, _duration).SetLoops(_repeats, _loops);
}
