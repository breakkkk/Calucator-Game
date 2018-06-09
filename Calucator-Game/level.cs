using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace Calucator_Game
{
    enum operators//op
    {
        plus=0,//添加
        add,//加
        subtract,//减
        multiply,//乘
        divide,//除
        del,//删除
        replace,//替换
        negative//正负
    }
    //由 http://json2csharp.chahuo.com/ 生成C#类
    public class Ops
    {
        public int op { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
    }

    public class Level
    {
        public int level { get; set; }
        public int  moves { get; set; }
        public int goal { get; set; }
        public List<Ops> ops { get; set; }
    }//关卡

    public class Levels
    {
        public int current { get; set; }
        public List<Level> Level { get; set; }
    }
    public class level
    {
        public string content;

        /// <summary>
        /// 以下参考自 https://wenku.baidu.com/view/708eb63a03768e9951e79b89680203d8ce2f6a9c.html
        /// 读取指定文件路径内容
        /// </summary>
        public string ReadFile(string FilePath)
        {
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
        public Level ReadLevel(int level)
        {
            Level l = null;
            return l;
        }

        /// <summary>
        /// 读出总关卡数
        /// </summary>
        /// <returns></returns>
        public int GetLevels()
        {
            return 0;
        }
    }
}
