
using System.ComponentModel.Composition;
using MEF.Core;

namespace SayHi
{
    [Export(typeof(IPlugin))]
    [ExportMetadata("Name","zx")]
    public class Say : IPlugin
    {
        private string _text;

        public string Text
        {
            get
            {
                return this._text;
            }

            set
            {
                switch (value)
                {
                    case "0":
                        this._text = "错误";
                        break;
                    case "1":
                        this._text = "正确";
                        break;
                    default:
                        this._text = value;
                        break;
                }
            }
        }

        public void Do()
        {
            System.Windows.MessageBox.Show(_text, "提示");
        }
    }
}
