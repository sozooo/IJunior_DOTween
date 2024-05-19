using DG.Tweening;
using UnityEngine;

public class SphereMover : ObjectTween
{
    [SerializeField] private Vector3 _endValue;

    private Vector3 _moveOffset;

    private void Start()
    {
        _moveOffset = transform.position + _endValue;

        transform.DOMove(_moveOffset, Duration).SetLoops(Repeats, LoopMode);
    }
}
