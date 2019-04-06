using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Xpo
{
    public interface IActionXpo
    {
        void DefaultDetailAction();
        void DetailAction(Type _target, CriteriaOperator _filter);
        void AttachPDF();
        
    }
}
