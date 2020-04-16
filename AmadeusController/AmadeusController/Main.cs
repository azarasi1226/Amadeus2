using System.Diagnostics;

namespace AmadeusController
{
    public class Main
    {
        private static Process amadeus = new Process();

        public static void Show()
        {
            amadeus.StartInfo.FileName = @"S:\Edit\AviUtl 2019\AviUtl\aviutl.exe";
            amadeus.Start();
        }

        /// <summary>
        /// amadeusが終了しているか
        /// </summary>
        /// <param name="param"></param>
        public static void CheckExit(ref bool param)
        {
            param = amadeus.HasExited;
        }
    }
}
