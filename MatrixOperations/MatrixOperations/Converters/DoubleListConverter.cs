using MatrixOperations.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MatrixOperations.Converters
{
    public class EditableValueTypeConverter<T> : IValueConverter where T : struct
    {
        class ItemWrapper
        {
            public ItemWrapper(IList<T> container, int index)
            {
                this.container = container;
                this.index = index;
            }

            IList<T> container;
            int index;
            public T Value
            {
                get { return container[index]; }
                set { container[index] = value; }
            }
        }

        public object Convert(object value, Type targetType, object p, CultureInfo ci)
        {
            var list = (IList<T>)value; 
            return Enumerable.Range(0, list.Count())
                                .Select(idx => new ItemWrapper(list, idx))
                                .ToList();
        }

        public object ConvertBack(object value, Type targetType, object p, CultureInfo ci)
        {
            throw new NotSupportedException();
        }
    }
    public class DoubleListConverter : EditableValueTypeConverter<double> { }

}
