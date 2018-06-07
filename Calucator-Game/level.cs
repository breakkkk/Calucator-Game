using System;
using System.Collections.Generic;
using System.IO;
namespace Calucator_Game
{

    //由 http://json2csharp.chahuo.com/ 生成C#类
    public class Ops
    {
        public string op { get; set; }
        public string num1 { get; set; }
    }

    public class Level
    {
        public string level { get; set; }
        public string moves { get; set; }
        public string goal { get; set; }
        public List<Ops> ops { get; set; }
    }

    public class RootObject
    {
        public string current { get; set; }
        public List<Level> level { get; set; }
    }
    class level
    {
        public string content;
        /// <summary>
        /// 以下参考自 https://wenku.baidu.com/view/708eb63a03768e9951e79b89680203d8ce2f6a9c.html
        /// 读取指定文件路径内容
        /// </summary>
        static string ReadFile(string FilePath)
        {
            byte[] BOM = new byte[3];//文件编码
            FileStream fs = null;
            try
            {
                fs = new FileStream(FilePath,FileMode.Open,FileAccess.ReadWrite);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            fs.Seek(0,System.IO.SeekOrigin.Begin);//移动到文件开始位置
            int FileSize = (int)fs.Length;
            byte[] FileBuffer = new byte[FileSize];
            int Count = fs.Read(FileBuffer, 0, FileSize);//读取
            fs.Close();
            fs.Dispose();
            string str = System.Text.Encoding.Default.GetString(FileBuffer);
            return str;
        }
        /// <summary>
        /// 读出指定关卡
        /// </summary>
        /// <param name="level">关卡</param>
        /// <returns></returns>
        public static Level ReadLevel(int level)
        {
            Level l = null;
            return l;
        }
        /// <summary>
        /// 读出总关卡数
        /// </summary>
        /// <returns></returns>
        public static int GetLevels()
        {
            return 0;
        }
    }
}
