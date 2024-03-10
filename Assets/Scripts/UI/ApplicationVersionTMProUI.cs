using TMPro;
using UnityEngine;

namespace Metadrive.Utils
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ApplicationVersionTMProUI : MonoBehaviour
    {
        [SerializeField] private string prefix;

        private TextMeshProUGUI _ugui;

        private void Start()
        {
            _ugui = GetComponent<TextMeshProUGUI>();
            _ugui.text = prefix + Application.version;
        }
    }
}
