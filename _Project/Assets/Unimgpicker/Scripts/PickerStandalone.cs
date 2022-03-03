#if UNITY_STANDALONE
using System.IO;
using SFB;
using UnityEngine;

namespace Kakera
{
    internal class PickerStandalone : IPicker
    {
        public void Show(string title, string outputFileName, int maxSize)
        {
            // フィルタ付きでファイルダイアログを開く
            var extensions = new[]
            {
                new ExtensionFilter( "画像ファイル", "png", "PNG", "jpg", "jpeg" ),
                new ExtensionFilter( "画像ファイル2", "bmp", "gif" )
            };
            var paths = StandaloneFileBrowser.OpenFilePanel(title, "", extensions, false);

            // 第一要素に対してのみ操作を行う
            if (paths.Length == 0) return;
            if (paths[0].Length != 0)
            {
                string destination = UnityEngine.Application.persistentDataPath + "/" + outputFileName;
                if (File.Exists(destination)) File.Delete(destination);
                File.Copy(paths[0], destination);
                Debug.Log("PickerOSX:" + destination);
                var receiver = GameObject.Find("Unimgpicker");
                if (receiver != null)
                {
                    receiver.SendMessage("OnComplete", UnityEngine.Application.persistentDataPath + "/" + outputFileName);
                }
            }
        }
    }
}
#endif