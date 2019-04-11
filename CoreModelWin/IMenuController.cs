using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModelWin
{
    interface IMenuController
    {
        void EnableSaveButton(Boolean _settings);
        void EnableDeleteButton(Boolean _settings);
        void EnableAddButton(Boolean _settings);
        void EnableEditButton(Boolean _settings);
    }
}
