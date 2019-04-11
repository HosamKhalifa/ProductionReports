using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelWin
{
    interface IEditableForm
    {
        void AddRecord();
        void DeleteRecord();
        void EditRecord();
        void SaveChanges();

       
    }
}
