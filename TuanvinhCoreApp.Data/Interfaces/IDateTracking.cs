using System;
using System.Collections.Generic;
using System.Text;

namespace TuanvinhCoreApp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }
        DateTime DateModified { set; get; }

    }
}
