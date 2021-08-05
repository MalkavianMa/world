using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValidMsg
{
    public class ValidMsg
    {

        #region 实体验证
        /// <summary>
        /// 实体验证日期2021年3月25日
        /// </summary>
        /// <param name="entiy">入参实体</param>
        /// <param name="param">验证参数字典key:属性值，value：属性名称</param>
        /// <returns>验证消息</returns>
        private string ValidMsgEntiy<T>(T entiy, Dictionary<string, string> param)
        {
            string msg = "";

            try
            {
                ArrayList array = new ArrayList();
                Type t = entiy.GetType();
                foreach (PropertyInfo pi in t.GetProperties())
                {
                    var name = pi.Name;//获得属性的名字,后面就可以根据名字判断来进行些自己想要的操作
                    var value = pi.GetValue(entiy, null);//用pi.GetValue获得值
                    var type = value?.GetType() ?? typeof(object);//获得属性的类型
                                                                  //验证实体属性是否为空，为空则拼接提示消息
                                                                  // object[] objs = pi.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), true);
                    if (param.ContainsKey(name))
                    {
                        if (string.IsNullOrEmpty(Convert.ToString(value)))
                        {
                            array.Add(param[name]);
                        }
                    }
                }
                string[] arrString = (string[])array.ToArray(typeof(string));
                if (arrString.Length > 0)
                {
                    msg = string.Join("、", arrString) + "不可为空！";

                }


            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }


            return msg;



        }

        #endregion

    }
}
