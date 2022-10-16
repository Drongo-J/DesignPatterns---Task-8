using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Subscriber : IObserver
    {
        public string Username { get; set; }
        public void Update(ISubject subject)
        {
            throw new NotImplementedException();
        }
    }
}
