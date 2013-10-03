using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.ContentManager.ContentManagement;
using Tridion.ContentManager.Extensibility;
using Tridion.ContentManager.Extensibility.Events;

namespace Tridion.Templates._2013.Events
{
    [TcmExtension("Tridion.Events.COMPANYNAME")] 
    public class EventSystem : TcmExtension
    {
        public EventSystem()
        {
            Subscribe();
        }
        public void Subscribe()
        {
            // Subscribe to OnComponentSavePre
            EventSystem.Subscribe<Component, SaveEventArgs>(OnComponentSavePre, EventPhases.Initiated);
        }
        private static void OnComponentSavePre(Component comp, SaveEventArgs args, EventPhases phase)
        {
            //Do Something...
        }
    }
}
