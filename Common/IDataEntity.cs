using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 添加实体接口
    /// </summary>
    public interface IDataEntity
    {

    }

    /// <summary>
    /// 查询条件接口
    /// </summary>
    public interface IQuery
    {

    }


    /// <summary>
    /// 查询条件接口
    /// </summary>
    public interface ICriteria
    {
        string Name { get; set; }
        bool IsCache { get; set; }
        bool IsTransaction { get; set; }
    }
}
