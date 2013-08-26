using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchemedxSsoUrlBuilder
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public short Value { get; set; }

        public ComboboxItem(string text, short value)
        {
            this.Text = text;
            this.Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
