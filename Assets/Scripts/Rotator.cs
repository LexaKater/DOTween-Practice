using DG.Tweening;

public class Rotator : Transormations
{
    private void Start() => transform.DORotate(EndPoint, Duration).SetLoops(Repeats, Loop);
}
