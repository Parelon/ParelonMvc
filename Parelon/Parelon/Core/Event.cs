using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parelon.Core
{
    public delegate void StatusChangedEventHandler ( object sender, EventArgs args);
    public class StatusEvent {
        public event StatusChangedEventHandler OnChangedEvent;
    }
}
