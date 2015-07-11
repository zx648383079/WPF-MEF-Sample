/*
*接口
*
*/

namespace MEF.Core
{
    /// <summary>
    /// 核心接口
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// 传递的内容
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// 触发的事件
        /// </summary>
        void Do();
    }

    public interface IPluginData
    {
        string Name { get; }
    }
    
}
