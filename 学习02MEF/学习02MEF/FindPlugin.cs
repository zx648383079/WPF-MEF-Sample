using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using MEF.Core;
using System.Collections.Generic;
using System;

namespace 学习02MEF
{
    /// <summary>
    /// 寻找插件
    /// </summary>
    public class FindPlugin
    {
        /// <summary>
        /// 插件集
        /// </summary>
        [ImportMany(typeof(IPlugin))]
        public Lazy<IPlugin,IPluginData>[] Plugins;


        private CompositionContainer _container;

        private void Init()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog("Plugins"));

            _container = new CompositionContainer(catalog);

            //IEnumerable<IPlugin> ips = _container.GetExportedValues<IPlugin>();

            //foreach (IPlugin item in ips)
            //{
            //    Plugins
            //}

            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionEx)
            {
                Console.WriteLine(compositionEx.ToString());
            }
        }
        /// <summary>
        /// 初始化，开始寻找插件
        /// </summary>
        public FindPlugin()
        {
            Init();
        }
    }
}
