using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// ビルドしたらMQL5のDLL読み込みフォルダに移動！！！！
    /// </summary>
    public class AmadeusController
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private static Queue<string> eventQ = new Queue<string>();
        private static Process amadeus = new Process();
        private static List<EventWaitHandle> events = new List<EventWaitHandle>();

        static AmadeusController()
        {
            AllocConsole();

            //イベント列挙
            foreach (var a in Enum.GetValues(typeof(NotificationEvent)))
            {
                events.Add(new EventWaitHandle(false, EventResetMode.AutoReset, a.ToString()));
            }
        }

        /// <summary>
        /// amadeus起動
        /// </summary>
        public static void Show()
        {
            //Amadeus起動
            amadeus.StartInfo.FileName = @"S:\Development\WorkSpace\C#\AmadeusC-\Amadeus\Amadeus\bin\Debug\Amadeus.exe";
            amadeus.Start();

            //非同期にしないとMQLのメソッド呼び出しで失敗する。
            //※永遠に関数呼び出しから帰ってこれないから
            Task.Run(() => {
                while (true)
                {
                    switch (EventWaitHandle.WaitAny(events.ToArray(), 1000, false))
                    {
                        case 0: eventQ.Enqueue("全通貨決済"); break;
                        case 1: eventQ.Enqueue("現通貨決済"); break;
                        default: Console.WriteLine("タイムアウト"); break;
                    }

                    //amadeusが停止している場合は終了
                    if (amadeus.HasExited) break;

                }

                Console.WriteLine("Amadeusを終了しました");
            });
        }

        /// <summary>
        /// Amadeusが終了しているか
        /// </summary>
        /// <returns>終了フラグ</returns>
        public static bool CheckExit()
        {
            return amadeus.HasExited;
        }

        /// <summary>
        /// 溜まっているイベントを一つ取り出す
        /// </summary>
        /// <returns>イベントメッセージ(無いときは空文字を返却)</returns>
        public static string CheckEvent()
        {
            //イベントがない場合はリターン
            if (eventQ.Count == 0)
                return string.Empty;

            return eventQ.Dequeue();
        }
    }
}
