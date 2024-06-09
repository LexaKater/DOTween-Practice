using DG.Tweening;

public class Scaler : Transormations
{
    private void Start() => transform.DOScale(EndPoint, Duration).SetLoops(Repeats, Loop);
}
