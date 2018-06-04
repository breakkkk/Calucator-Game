using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //fs.Read(BOM, 0, 3);
            //Encoding ScriptEncode;
            //if (BOM[0] == 255 && BOM[1] == 254)//BOM:FF EE
            //    ScriptEncode = Encoding.Unicode;
            //else if (BOM[0] == 254 && BOM[1] == 255)//FE FF
            //    ScriptEncode = Encoding.BigEndianUnicode;
            //else if (BOM[0] == 239 && BOM[1] == 187 && BOM[2] == 191)//EF BB BF
            //    ScriptEncode = Encoding.UTF8;
            //else
            //    ScriptEncode = Encoding.Default;//ANSI编码
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
