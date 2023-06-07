using UnityEngine;

namespace _Project.Scripts.Gradient
{
    public class GridSkyboxSetter : MonoBehaviour
    {
        [SerializeField] private Color[] _firstColorList;
        [SerializeField] private Color[] _secondColorList;

        private Material _skybox;

        private void Start()
        {
            _skybox = RenderSettings.skybox;
            SetSkyboxGradientColor();
        }

        private void SetSkyboxGradientColor()
        {
            Color firstColor = _firstColorList[Random.Range(0, _firstColorList.Length)];
            Color secondColor = _secondColorList[Random.Range(0, _secondColorList.Length)];

            float t = Mathf.InverseLerp(-2f, 2f, transform.position.y);
            Color lerpColor = Color.Lerp(firstColor, secondColor, t);
            
            _skybox.SetColor("_Tint",lerpColor);
        }
    }
}