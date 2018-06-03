using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calucator_Game
{
  
    class level
    {
        #region 结构体与枚举
        enum op {//操作符
            plus=0,//向末尾添加一位数
            add,//加
            subtract,//减
            multiply,//乘
            divide,//除
            del,//删除
            replace//替换
        };
        struct operation {//具体针对每一个按钮要执行的操作
            op op { get; set; }//操作符
            int num1 { get; set; }//操作数1
            int num2 { get; set; }//操作数2 替换时使用
            int bt { get; set; }//按钮ID
        }
        struct Level//关卡结构数据
        {
            int moves { get; set; }//可行动次数
            int goal { set; get; }//目标数
            int num { get; set; }//起始数
            operation[] action{get;set ;}//可执行的操作
        }
        #endregion
        
        /// <summary>
        /// 读出指定关卡
        /// </summary>
        /// <param name="level">关卡</param>
        /// <returns></returns>
        static string ReadLevel(int level)
        {
            return "";
        }
        /// <summary>
        /// 读出总关卡数
        /// </summary>
        /// <returns></returns>
        static int GetLevel()
        {
            return 0;
        }
    }
}
