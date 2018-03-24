using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public interface IFigure
    {
       void Draw(ICanvas canvas);
       string Name { get; }
    }
}
