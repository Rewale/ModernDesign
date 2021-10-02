using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.Model
{
    class db
    {
        private static bibliotekaEntities _context;

        public static bibliotekaEntities GetContext()
        {
            if (_context == null)
                _context = new bibliotekaEntities();
            return _context;
        }
    }
}
