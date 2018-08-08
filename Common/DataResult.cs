using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 操作数据库结果实体
    /// </summary>
    /// <typeparam name="T">可变参数</typeparam>
    public class DataResult<T> where T : class, IDataResult, new()
    {
        /// <summary>
        /// 返回实体列表
        /// </summary>
        public List<T> EntityList { get; set; }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误后返回的错误信息
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// 用户自定义返回的数据
        /// </summary>
        public object CustomData { get; set; }
    }
}
