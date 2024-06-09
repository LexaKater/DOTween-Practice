using UnityEngine;
using DG.Tweening;

public class Colorist : Transormations
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;

    private void Start() => _renderer.DOColor(_color, Duration).SetLoops(Repeats, Loop);
}
