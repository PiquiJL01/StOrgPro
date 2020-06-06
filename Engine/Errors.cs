using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FailedLogin : Exception { }

    public class NoDBConnection : Exception { }

    public class FailedToRemove : Exception { }

    public class WrongUserType : Exception { }

    public class AlreadyExists : Exception { }

    public class DoesNotExist : Exception { }

    public class InventoryCreation : Exception { }
}
