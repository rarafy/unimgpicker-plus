# unimgpicker-plus

Image picker for Unity iOS/Android + Windows


## 使い方
1. ```unimgpicker.unitypackage```をUnityのプロジェクトにインポートします。<br>
![image](https://user-images.githubusercontent.com/33755507/131508711-7efb16f2-d453-4e92-acf7-a35ebe7943fa.png)
<br>

2. ```Unimgpicker/Editor/NSPhotoLibraryUsageDescription.txt```でライブラリアクセスの理由を記述します。<br>
例：**Unimgpicker/Editor/NSPhotoLibraryUsageDescription.txt**<br>
```
Use the image to create your profile.
```
<br>

3. ```Assets/Unimgpicker/Prefabs/Unimgpicker.prefab```をシーンにドロップし、Buttonを作ります。<br>
![image](https://user-images.githubusercontent.com/33755507/131512106-ee9804ec-c3bb-4a46-9925-447f2eda4923.png)
![image](https://user-images.githubusercontent.com/33755507/131512285-93d608b1-506d-4560-97d7-c0d3993f02df.png)
<br>

4. ButtonにAddImageを加え、次のようにSS ImageをInspectorから設定します。<br>
![image](https://user-images.githubusercontent.com/33755507/131512416-420a2d43-c3be-4698-a39e-5af84738bf81.png)<br>
AddImage.csの```Texture(Texture2D), Texture2(Sprite)```に対して参照をかけることで画像を得ることが出来ます。

### サンプルデータ
```Assets/Unimgpicker/Samples```に入っています。
