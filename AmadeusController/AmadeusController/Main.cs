using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AmadeusController
{
    public class Main
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private static Queue<string> eventQ = new Queue<string>();
        private static Process amadeus = new Process();
        private static EventWaitHandle[] events = new EventWaitHandle[2];

        static Main()
        {
            AllocConsole();
            //イベント登録
            events[0] = new EventWaitHandle(false, EventResetMode.AutoReset, "test_event_pokemon_go");
            events[1] = new EventWaitHandle(false, EventResetMode.AutoReset, "test_event_pokemon_gogo");
        }

        /// <summary>
        /// amadeus起動
        /// </summary>
        public static void Show()
        {
            //Amadeus起動
            amadeus.StartInfo.FileName = @"S:\Development\WorkSpace\C#\Amadeus V1\Amadeus\Amadeus\bin\Debug\Amadeus.exe";
            amadeus.Start();

            //非同期にしないとMQLのメソッド呼び出しで失敗する。
            Task.Run(() => {
                while (true)
                {
                    Console.WriteLine("ループ");
                    switch (EventWaitHandle.WaitAny(events, 1000, false))
                    {
                        case 0: eventQ.Enqueue("楽しいね"); break;
                        case 1: eventQ.Enqueue("fuck"); break;
                        default: Console.WriteLine("タイムアウト"); break;
                    }

                    //amadeusが停止している場合は終了
                    if (amadeus.HasExited) break;

                }

                Console.WriteLine("Amadeusを終了しました");
            });
        }

        /// <summary>
        /// amadeusが終了しているか
        /// </summary>
        /// <param name="param"></param>
        public static bool CheckExit()
        {
            return amadeus.HasExited;
        }

        /// <summary>
        /// AmadeusからのイベントをMQL側に通知
        /// </summary>
        /// <param name="param"></param>
        public static string CheckEvent()
        {
            //イベントがない場合はリターン
            if (eventQ.Count == 0)
                return "";

            return eventQ.Dequeue();
        }
    }
}
