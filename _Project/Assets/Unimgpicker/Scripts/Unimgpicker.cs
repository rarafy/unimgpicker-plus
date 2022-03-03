using UnityEngine;
using System.Collections;

namespace Kakera
{
    public class Unimgpicker : MonoBehaviour
    {
        public delegate void ImageDelegate(string path);

        public delegate void ErrorDelegate(string message);

        public event ImageDelegate Completed;

        public event ErrorDelegate Failed;

        private IPicker picker =
#if UNITY_EDITOR
            new Picker_editor();
#elif UNITY_IOS
            new PickeriOS();
#elif UNITY_ANDROID
            new PickerAndroid();
#elif UNITY_STANDALONE
        new PickerStandalone();
#else
            new PickerUnsupported();
#endif

        public void Show(string title, string outputFileName, int maxSize)
        {
            picker.Show(title, outputFileName, maxSize);
        }

        private void OnComplete(string path)
        {
            var handler = Completed;
            if (handler != null)
            {
                handler(path);
            }
        }

        private void OnFailure(string message)
        {
            var handler = Failed;
            if (handler != null)
            {
                handler(message);
            }
        }
    }
}