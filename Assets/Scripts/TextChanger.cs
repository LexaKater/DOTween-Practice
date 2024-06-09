using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    private const string NewText = "Хорошего тебе дня";
    private const string AddingText = " и продуктивной недели.";
    private const string ReplacementText = "Ты лучший!";

    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private ScrambleMode _scramble;

    private float _delay = 4;

    private void Start()
    {
        StartCoroutine(StartChange());
    }

    private IEnumerator StartChange()
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);

        yield return wait;

        _text.DOText(NewText, _duration);

        yield return wait;

        _text.DOText(AddingText, _duration).SetRelative();

        yield return wait;

        _text.DOText(ReplacementText, _duration, true, _scramble);
    }
}
