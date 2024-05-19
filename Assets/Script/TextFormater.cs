using DG.Tweening;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextFormater : ObjectTween
{
    [SerializeField] private string _replacedText;
    [SerializeField] private string _additionalText;
    [SerializeField] private string _hackedText;

    private Text _text;
    private Tweener _tweener;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Replace();
    }

    private void Replace()
    {
        _tweener = _text.DOText(_replacedText, Duration);

        if(_tweener.onKill != null)
        {
            _tweener.onKill -= Replace;
        }

        _tweener.onKill += Add;
    }

    private void Add()
    {
        _tweener = _text.DOText(_additionalText, Duration).SetRelative();

        _tweener.onKill -= Add;
        _tweener.onKill += Hack;
    }

    private void Hack()
    {
        _tweener = _text.DOText(_hackedText, Duration, true, ScrambleMode.All);

        _tweener.onKill -= Hack;
        _tweener.onKill += Replace;
    }
}
