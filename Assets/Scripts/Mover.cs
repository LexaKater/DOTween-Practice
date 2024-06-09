using DG.Tweening;

public class Mover : Transormations
{
    private void Start() => transform.DOMove(EndPoint, Duration).SetLoops(Repeats, Loop);
}
