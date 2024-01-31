using SistemaControloAlerta.Forms;
using SistemaControloAlerta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControloAlerta.Presenters
{
    public interface IDEPAPresenter
    {
        IDEPAListView listView { get; set; }
        IDEPAEditView editView { get; set; }

        public IDEPAPresenter();



    }
}
