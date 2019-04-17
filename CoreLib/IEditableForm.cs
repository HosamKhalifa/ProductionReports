using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   public interface IEditableForm
    {
        void AddRecord();
        void DeleteRecord();
        void EditRecord();
        void SaveChanges();


    }
}
