using DG.Tweening;
using UnityEngine;

public class ColorChanger : ObjectTween
{
    [SerializeField] private Color _color;
    [SerializeField] private Material _material;

    private void Start()
    {
        _material.DOColor(_color, Duration).SetLoops(Repeats, LoopMode);
    }
}
