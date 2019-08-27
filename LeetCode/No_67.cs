using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_67
    {
        public string AddBinary(string a, string b)
        {
            var max = Math.Max(a.Length, b.Length) + 1;
            //按总长度补位，以便统一处理，否则要考虑边界
            var a2 = a.PadLeft(max, '0');
            var b2 = b.PadLeft(max, '0');
            //定义list存中间计算结果
            var list = new List<int>();
            //进位标志
            var carryFlag = false;
            for (int i = max - 1; i >= 0; i--)
            {
                var add = int.Parse(a2[i].ToString())
                          + int.Parse(b2[i].ToString());
                //计算当前位的值，如果之前进位标志为真，则额外+1
                if (carryFlag) add++;
                //大于等于2时，此时仍然需要进位，带入下一次循环
                carryFlag = add >= 2;
                //存入中间计算结果
                list.Add(add % 2);
            }
            //定义结果
            var res = string.Empty;
            //反转，list是按逆序从低位到高位的
            list.Reverse();
            //遍历输出到res
            list.ForEach(r => { res += r.ToString(); });
            //取消最高位0
            res = res.TrimStart('0');
            //如果空了，返回0
            if (res.Length == 0) res = "0";
            //返回结果
            return res;



        }
    }
}
