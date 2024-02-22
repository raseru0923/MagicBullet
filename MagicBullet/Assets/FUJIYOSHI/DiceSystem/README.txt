// ダイスシステムを使用するためには
UniTaskが必要です。

以下をgitURLを使用してPackageManagerからインストールしてください。
https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask

使用方法を以下に示します。
using System.Threading;
using Cysharp.Threading.Tasks;
の二つをusingしてください。

StartやUpdateでpublic async UniTask<JudgementType> HundredDiceRoll(int successRate)を使用する場合。

   private async void Start()
   {
       var result = await HundredDiceRoll(50);
       Debug.Log(result);
   }
   private async void Update()
   {
       var result = await HundredDiceRoll(50);
       Debug.Log(result);
   }

というように記述します。
