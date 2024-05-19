using DG.Tweening;
using UnityEngine;

public class CubeTransformator : ObjectTween
{
    [SerializeField] private Vector3 _endValueMove;
    [SerializeField] private Vector3 _endPointRotate;
    [SerializeField] private Vector3 _endPointScale;

    private Vector3 _moveOffset;

    private void Start()
    {
        _moveOffset = transform.position + _endValueMove;

        transform.DOMove(_moveOffset, Duration).SetLoops(Repeats, LoopMode);
        transform.DORotate(_endPointRotate, Duration).SetLoops(Repeats, LoopMode);
        transform.DOScale(_endPointScale, Duration).SetLoops(Repeats, LoopMode);
    }
}
