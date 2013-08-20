using EnvDTE;
using Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    public class AddinConnector : IDTExtensibility2, IDTCommandTarget
    {
        #region IDTCommandTarget
        public void Exec(string CmdName, vsCommandExecOption ExecuteOption, ref object VariantIn, ref object VariantOut, ref bool Handled)
        {
            throw new NotImplementedException();
        }

        public void QueryStatus(string CmdName, vsCommandStatusTextWanted NeededText, ref vsCommandStatus StatusOption, ref object CommandText)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IDTExtensibility2
        public void OnAddInsUpdate(ref Array custom)
        {
            throw new NotImplementedException();
        }

        public void OnBeginShutdown(ref Array custom)
        {
            throw new NotImplementedException();
        }

        public void OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            throw new NotImplementedException();
        }

        public void OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            throw new NotImplementedException();
        }

        public void OnStartupComplete(ref Array custom)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
